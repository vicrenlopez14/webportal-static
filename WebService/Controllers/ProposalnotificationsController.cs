using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebService.Data;
using WebService.Models.Generated;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProposalnotificationsController : ControllerBase
    {
        private readonly ProFindContext _context;

        public ProposalnotificationsController(ProFindContext context)
        {
            _context = context;
        }

        // GET: api/Proposalnotifications
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Proposalnotification>>> GetProposalnotifications()
        {
            return await _context.Proposalnotifications.ToListAsync();
        }

        // GET: api/Proposalnotifications/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Proposalnotification>> GetProposalnotification(string id)
        {
            var proposalnotification = await _context.Proposalnotifications.FindAsync(id);

            if (proposalnotification == null)
            {
                return NotFound();
            }
            
            return proposalnotification;
        }

        // PUT: api/Proposalnotifications/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProposalnotification(string id, Proposalnotification proposalnotification)
        {
            if (id != proposalnotification.IdPn)
            {
                return BadRequest();
            }

            _context.Entry(proposalnotification).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProposalnotificationExists(id))
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

        // POST: api/Proposalnotifications
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Proposalnotification>> PostProposalnotification(Proposalnotification proposalnotification)
        {
            _context.Proposalnotifications.Add(proposalnotification);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProposalnotificationExists(proposalnotification.IdPn))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProposalnotification", new { id = proposalnotification.IdPn }, proposalnotification);
        }

        // DELETE: api/Proposalnotifications/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProposalnotification(string id)
        {
            var proposalnotification = await _context.Proposalnotifications.FindAsync(id);
            if (proposalnotification == null)
            {
                return NotFound();
            }

            _context.Proposalnotifications.Remove(proposalnotification);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProposalnotificationExists(string id)
        {
            return _context.Proposalnotifications.Any(e => e.IdPn == id);
        }
    }
}
