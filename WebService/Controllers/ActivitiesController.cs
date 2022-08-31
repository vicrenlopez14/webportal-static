using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebService.Data;
using WebService.Models;
using Activity = WebService.Models.Generated.Activity;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitiesController : ControllerBase
    {
        private readonly ProFindContext _context;

        public ActivitiesController(ProFindContext context)
        {
            _context = context;
        }

        // GET: api/Activities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Activity>>> GetActivities()
        {
            if (_context.Activities == null)
            {
                return NotFound();
            }

            return await _context.Activities.ToListAsync();
        }

        // GET: api/Activities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(string id)
        {
            if (_context.Activities == null)
            {
                return NotFound();
            }

            var activity = await _context.Activities.FindAsync(id);

            if (activity == null)
            {
                return NotFound();
            }

            return activity;
        }

        [HttpGet("search/")]
        public async Task<ActionResult<IEnumerable<Activity>>> SearchActivities([FromQuery] string projectId,
            [FromQuery] string title)
        {
            var result = await (from act in _context.Activities
                where (act.IdPj1 == projectId && act.TitleA.Contains(title))
                select act).ToListAsync();

            if (result.Any() == false)
            {
                return NotFound();
            }

            return result;
        }

        [HttpGet("search/paginated")]
        public async Task<ActionResult<IEnumerable<Activity>>> SearchActivitiesPaginated([FromQuery] string projectId,
            [FromQuery] string title, [FromQuery] string limit,
            [FromQuery] string offset)
        {
            var query = (from act in _context.Activities
                where (act.IdPj1 == projectId && act.TitleA.Contains(title))
                select act);

            query = (from activity in _context.Activities select activity).OrderByDescending(x => x.ExpectedBeginA)
                .Skip(int.Parse(offset)).Take(int.Parse(limit));

            var result = await query.ToListAsync();

            if (result.Any() == false)
            {
                return NotFound();
            }

            return result;
        }

        [HttpGet("filter/")]
        public async Task<ActionResult<IEnumerable<Activity>>> FilterActivities([FromQuery] DateOnly? expectedBegin,
            [FromQuery] string? expectedBeginRel,
            [FromQuery] DateOnly? expectedEnd, [FromQuery] string? expectedEndRel,
            [FromQuery] string? idProject,
            [FromQuery] string? idTag)
        {
            var query = _context.Activities.Where(act => true);

            if (idProject != null)
            {
                query = _context.Activities.Where(act => act.IdPj1 == idProject);
            }

            if (idTag != null)
            {
                query = _context.Activities.Where(act => act.IdT1 == idTag);
            }

            if (expectedBegin != null)
            {
                switch (expectedBeginRel)
                {
                    case "lte":
                        query = _context.Activities.Where(act => act.ExpectedBeginA <= expectedBegin);
                        break;
                    case "eq":
                        query = _context.Activities.Where(act => act.ExpectedBeginA == expectedBegin);
                        break;
                    case "gte":
                        query = _context.Activities.Where(act => act.ExpectedBeginA >= expectedBegin);
                        break;
                }
            }

            if (expectedEnd != null)
            {
                switch (expectedEndRel)
                {
                    case "lte":
                        query = _context.Activities.Where(act => act.ExpectedEndA <= expectedEnd);
                        break;
                    case "eq":
                        query = _context.Activities.Where(act => act.ExpectedEndA == expectedEnd);
                        break;
                    case "gte":
                        query = _context.Activities.Where(act => act.ExpectedEndA >= expectedEnd);
                        break;
                }
            }

            var result = await query.ToListAsync();

            if (result.Any() == false)
            {
                return NotFound();
            }

            return result;
        }

        [HttpGet("paginated")]
        public async Task<ActionResult<IEnumerable<Activity>>> GetActivitiesPaginated([FromQuery] string limit,
            [FromQuery] string offset)
        {
            var query = (from activity in _context.Activities select activity).OrderByDescending(x => x.ExpectedBeginA)
                .Skip(int.Parse(offset)).Take(int.Parse(limit));

            return await _context.Activities.ToListAsync();
        }

        // PUT: api/Activities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActivity(string id, Activity activity)
        {
            if (id != activity.IdA)
            {
                return BadRequest();
            }

            _context.Entry(activity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActivityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Activities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Activity>> PostActivity(Activity activity)
        {
            if (_context.Activities == null)
            {
                return Problem("Entity set 'ProFindContext.Activities'  is null.");
            }

            _context.Activities.Add(activity);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ActivityExists(activity.IdA))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetActivity", new {id = activity.IdA}, activity);
        }

        // DELETE: api/Activities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivity(string id)
        {
            if (_context.Activities == null)
            {
                return NotFound();
            }

            var activity = await _context.Activities.FindAsync(id);
            if (activity == null)
            {
                return NotFound();
            }

            _context.Activities.Remove(activity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ActivityExists(string id)
        {
            return (_context.Activities?.Any(e => e.IdA == id)).GetValueOrDefault();
        }
    }
}