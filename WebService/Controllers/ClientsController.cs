using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebService.Data;
using WebService.Models;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly ProFindContext _context;

        public ClientsController(ProFindContext context)
        {
            _context = context;
        }

        // Register a client user method
        // POST: api/Clients
        [HttpPost("Register")]
        public async Task<IActionResult> Register(Client client)
        {
            if (ModelState.IsValid)
            {
                _context.Add(client);
                await _context.SaveChangesAsync();
                return Ok(client);
            }

            return BadRequest(ModelState);
        }

        // Login a client user method
        // Login an Admin method
        [HttpPost("Login")]
        public async Task<IActionResult> Login(Client client)
        {
            if (ModelState.IsValid)
            {
                var clientFromDb =
                    await _context.Clients.FirstOrDefaultAsync(a =>
                        a.EmailC == client.EmailC && a.PasswordC == client.PasswordC);
                if (clientFromDb != null)
                {
                    return Ok(clientFromDb);
                }
            }

            return BadRequest(ModelState);
        }

        // GET: api/Clients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client>>> GetClients()
        {
            if (_context.Clients == null)
            {
                return NotFound();
            }

            return await _context.Clients.ToListAsync();
        }

        // GET: api/Clients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> GetClient(string id)
        {
            if (_context.Clients == null)
            {
                return NotFound();
            }

            var client = await _context.Clients.FindAsync(id);

            if (client == null)
            {
                return NotFound();
            }

            return client;
        }

        // PUT: api/Clients/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClient(string id, Client client)
        {
            if (id != client.IdC)
            {
                return BadRequest();
            }

            _context.Entry(client).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientExists(id))
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

        // POST: api/Clients
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Client>> PostClient(Client client)
        {
            if (_context.Clients == null)
            {
                return Problem("Entity set 'ProFindContext.Clients'  is null.");
            }

            _context.Clients.Add(client);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ClientExists(client.IdC))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetClient", new {id = client.IdC}, client);
        }

        // DELETE: api/Clients/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClient(string id)
        {
            if (_context.Clients == null)
            {
                return NotFound();
            }

            var client = await _context.Clients.FindAsync(id);
            if (client == null)
            {
                return NotFound();
            }

            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClientExists(string id)
        {
            return (_context.Clients?.Any(e => e.IdC == id)).GetValueOrDefault();
        }
    }
}