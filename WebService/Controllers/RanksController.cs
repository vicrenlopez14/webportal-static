using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebService.Data;
using WebService.Models;
using Rank = WebService.Models.Generated.Rank;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RanksController : ControllerBase
    {
        private readonly ProFindContext _context;

        public RanksController(ProFindContext context)
        {
            _context = context;
        }

        // GET: api/Ranks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rank>>> GetRanks()
        {
            if (_context.Ranks == null)
            {
                return NotFound();
            }

            return await _context.Ranks.ToListAsync();
        }

        // GET: api/Ranks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rank>> GetRank(int id)
        {
            if (_context.Ranks == null)
            {
                return NotFound();
            }

            var rank = await _context.Ranks.FindAsync(id);

            if (rank == null)
            {
                return NotFound();
            }

            return rank;
        }

        [HttpGet("search/")]
        public async Task<ActionResult<IEnumerable<Rank>>> SearchRanks([FromQuery] string nameRanks)
        {
            var result = await (from rank in _context.Ranks 
            where (rank.NameR.Contains(nameRanks))
            select rank).ToListAsync();

            if(result.Any() == false)
            {
                return NotFound();
            }
            return result;
        }


        [HttpGet("search/paginated")]
        public async Task<ActionResult<IEnumerable<Rank>>> SearchRanksPaginated([FromQuery]
            string nameRanks, [FromQuery] string limit, [FromQuery] string offset)
        {
            var query = from rank in _context.Ranks
                         where rank.NameR.Contains(nameRanks)
                         select rank;

            query = (from rank in _context.Ranks select rank).OrderByDescending(x => x.NameR)
                .Skip(int.Parse(offset)).Take(int.Parse(limit));

            var result = await query.ToListAsync();

            if (result.Any() == false)
            {
                return NotFound();
            }

            return result;
        }

        [HttpGet("filter/")]
        public async Task<ActionResult<IEnumerable<Rank>>> FilterRanks([FromQuery] string nameRanks,
           [FromQuery] string? idR)

        {
            var query = _context.Ranks.Where(ranks => true);

            if (nameRanks != null)
            {
                query = _context.Ranks.Where(ranks => ranks.NameR == nameRanks);
            }

            if (idR != null)
            {
                query = _context.Ranks.Where(ranks => ranks.NameR == nameRanks);
            }

            var result = await query.ToListAsync();

            if (result.Any() == false)
            {
                return NotFound();
            }

            return result;
        }

        [HttpGet("paginated")]
        public async Task<ActionResult<IEnumerable<Rank>>> GetRanksPaginated([FromQuery] string limit,
            [FromQuery] string offset)
        {
            var query = (from rank in _context.Ranks select rank).OrderByDescending(x => x.NameR)
                .Skip(int.Parse(offset)).Take(int.Parse(limit));

            return await _context.Ranks.ToListAsync();
        }

        // PUT: api/Ranks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRank(int id, Rank rank)
        {
            if (id != rank.IdR)
            {
                return BadRequest();
            }

            _context.Entry(rank).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RankExists(id))
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

        // POST: api/Ranks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Rank>> PostRank(Rank rank)
        {
            if (_context.Ranks == null)
            {
                return Problem("Entity set 'ProFindContext.Ranks'  is null.");
            }

            _context.Ranks.Add(rank);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRank", new {id = rank.IdR}, rank);
        }

        // DELETE: api/Ranks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRank(int id)
        {
            if (_context.Ranks == null)
            {
                return NotFound();
            }

            var rank = await _context.Ranks.FindAsync(id);
            if (rank == null)
            {
                return NotFound();
            }

            _context.Ranks.Remove(rank);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RankExists(int id)
        {
            return (_context.Ranks?.Any(e => e.IdR == id)).GetValueOrDefault();
        }
    }
}