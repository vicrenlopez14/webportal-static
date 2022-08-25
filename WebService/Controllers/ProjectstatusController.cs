using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebService.Data;
using WebService.Models;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProjectstatusController : ControllerBase
    {
        private readonly ProFindContext _context;

        public ProjectstatusController(ProFindContext context)
        {
            _context = context;
        }

        // GET: api/Projectstatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Projectstatus>>> GetProjectstatuses()
        {
          if (_context.Projectstatuses == null)
          {
              return NotFound();
          }
            return await _context.Projectstatuses.ToListAsync();
        }

        // GET: api/Projectstatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Projectstatus>> GetProjectstatus(int id)
        {
          if (_context.Projectstatuses == null)
          {
              return NotFound();
          }
            var projectstatus = await _context.Projectstatuses.FindAsync(id);

            if (projectstatus == null)
            {
                return NotFound();
            }

            return projectstatus;
        }

        // PUT: api/Projectstatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProjectstatus(int id, Projectstatus projectstatus)
        {
            if (id != projectstatus.IdPs)
            {
                return BadRequest();
            }

            _context.Entry(projectstatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectstatusExists(id))
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

        // POST: api/Projectstatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Projectstatus>> PostProjectstatus(Projectstatus projectstatus)
        {
          if (_context.Projectstatuses == null)
          {
              return Problem("Entity set 'ProFindContext.Projectstatuses'  is null.");
          }
            _context.Projectstatuses.Add(projectstatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProjectstatus", new { id = projectstatus.IdPs }, projectstatus);
        }

        // DELETE: api/Projectstatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProjectstatus(int id)
        {
            if (_context.Projectstatuses == null)
            {
                return NotFound();
            }
            var projectstatus = await _context.Projectstatuses.FindAsync(id);
            if (projectstatus == null)
            {
                return NotFound();
            }

            _context.Projectstatuses.Remove(projectstatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProjectstatusExists(int id)
        {
            return (_context.Projectstatuses?.Any(e => e.IdPs == id)).GetValueOrDefault();
        }
    }
}
