using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebService.Data;
using WebService.Models;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProposalsController : ControllerBase
    {
        private readonly ProFindContext _context;

        public ProposalsController(ProFindContext context)
        {
            _context = context;
        }

        // GET: api/Proposals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Proposal>>> GetProposals()
        {
            if (_context.Proposals == null)
            {
                return NotFound();
            }

            return await _context.Proposals.ToListAsync();
        }

        // GET: api/Proposals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Proposal>> GetProposal(string id)
        {
            if (_context.Proposals == null)
            {
                return NotFound();
            }

            var proposal = await _context.Proposals.FindAsync(id);

            if (proposal == null)
            {
                return NotFound();
            }

            return proposal;
        }

        // PUT: api/Proposals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProposal(string id, Proposal proposal)
        {
            if (id != proposal.IdPp)
            {
                return BadRequest();
            }

            _context.Entry(proposal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProposalExists(id))
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

        // POST: api/Proposals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Proposal>> PostProposal(Proposal proposal)
        {
            if (_context.Proposals == null)
            {
                return Problem("Entity set 'ProFindContext.Proposals'  is null.");
            }

            _context.Proposals.Add(proposal);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProposalExists(proposal.IdPp))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProposal", new {id = proposal.IdPp}, proposal);
        }

        // DELETE: api/Proposals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProposal(string id)
        {
            if (_context.Proposals == null)
            {
                return NotFound();
            }

            var proposal = await _context.Proposals.FindAsync(id);
            if (proposal == null)
            {
                return NotFound();
            }

            _context.Proposals.Remove(proposal);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProposalExists(string id)
        {
            return (_context.Proposals?.Any(e => e.IdPp == id)).GetValueOrDefault();
        }
    }
}