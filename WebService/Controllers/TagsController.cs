using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebService.Data;
using WebService.Models;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly ProFindContext _context;

        public TagsController(ProFindContext context)
        {
            _context = context;
        }

        // GET: api/Tags
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tag>>> GetTags()
        {
            if (_context.Tags == null)
            {
                return NotFound();
            }

            return await _context.Tags.ToListAsync();
        }

        // GET: api/Tags/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tag>> GetTag(string id)
        {
            if (_context.Tags == null)
            {
                return NotFound();
            }

            var tag = await _context.Tags.FindAsync(id);

            if (tag == null)
            {
                return NotFound();
            }

            return tag;
        }

        [HttpGet("search/")]
        public async Task<ActionResult<IEnumerable<Tag>>> SearchTags([FromQuery] string tagId,
           [FromQuery] string nameTag)
        {
            var result = await (from tag in _context.Tags
                where (tag.IdT == tagId && tag.NameT.Contains(nameTag))
                select tag).ToListAsync();

            if (result.Any() == false)
            {
                return NotFound();
            }
            return result;
        }

        [HttpGet("search/paginated")]
        public async Task<ActionResult<IEnumerable<Tag>>> SearchTagPaginated([FromQuery] string tagId,
            [FromQuery] string nameTag, [FromQuery] string limit, [FromQuery] string offset)
        {
            var query = (from tag in _context.Tags
                         where (tag.IdT == tagId && tag.NameT.Contains(nameTag))
                         select tag);

            query = (from tag in _context.Tags select tag).OrderByDescending(x => x.NameT)
                .Skip(int.Parse(offset)).Take(int.Parse(limit));

            var result = await query.ToListAsync();

            if (result.Any() == false)
            {
                return NotFound();
            }

            return result;
        }

        [HttpGet("filter/")]
        public async Task<ActionResult<IEnumerable<Tag>>> FilterTags([FromQuery] string idTag,
          [FromQuery] string? nameTag)

        {
            var query = _context.Tags.Where(tag => true);

            if (nameTag != null)
            {
                query = _context.Tags.Where(tag => tag.NameT == nameTag);
            }

            if (idTag != null)
            {
                query = _context.Tags.Where(tag => tag.IdT == idTag);
            }

            var result = await query.ToListAsync();

            if (result.Any() == false)
            {
                return NotFound();
            }

            return result;
        }

        [HttpGet("paginated")]
        public async Task<ActionResult<IEnumerable<Tag>>> GetTagPaginated([FromQuery] string limit,
            [FromQuery] string offset)
        {
            var query = (from tag in _context.Tags select tag).OrderByDescending(x => x.NameT)
                .Skip(int.Parse(offset)).Take(int.Parse(limit));

            return await _context.Tags.ToListAsync();
        }


        // PUT: api/Tags/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTag(string id, Tag tag)
        {
            if (id != tag.IdT)
            {
                return BadRequest();
            }

            _context.Entry(tag).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TagExists(id))
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

        // POST: api/Tags
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tag>> PostTag(Tag tag)
        {
            if (_context.Tags == null)
            {
                return Problem("Entity set 'ProFindContext.Tags'  is null.");
            }

            _context.Tags.Add(tag);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TagExists(tag.IdT))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTag", new {id = tag.IdT}, tag);
        }

        // DELETE: api/Tags/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTag(string id)
        {
            if (_context.Tags == null)
            {
                return NotFound();
            }

            var tag = await _context.Tags.FindAsync(id);
            if (tag == null)
            {
                return NotFound();
            }

            _context.Tags.Remove(tag);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TagExists(string id)
        {
            return (_context.Tags?.Any(e => e.IdT == id)).GetValueOrDefault();
        }
    }
}