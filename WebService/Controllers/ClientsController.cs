using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebService.Data;
using WebService.Models;
using Client = WebService.Models.Generated.Client;

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
        // POST: api/Clients/Register
        [HttpPost("Register")]
        public async Task<IActionResult> RegisterClient(Client client)
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
        // POST: api/Clients/Login
        [HttpPost("Login")]
        public async Task<IActionResult> LoginClient(Client client)
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

            return CreatedAtAction("GetClient", new { id = client.IdC }, client);
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

        [HttpGet("search/")]
        public async Task<ActionResult<IEnumerable<Client>>>SearchCliens([FromQuery] string IdC,
            [FromQuery] string Name)
        {
            var result = await (from clien in _context.Clients
                                where (clien.IdC == IdC && clien.NameC.Contains(Name))
                                select clien).ToListAsync();

            if (result.Any() == false)
            {
                return NotFound();
            }

            return result;
        }


        [HttpGet("search/paginated")]
        public async Task<ActionResult<IEnumerable<Client>>>SearchClient([FromQuery] string idC,
         [FromQuery] string Name, [FromQuery] string limit,
         [FromQuery] string offset)
        {
            var query = (from Client in _context.Clients
                         where (Client.IdC == idC && Client.NameC.Contains(Name))
                         select Client);

            query = (from Client in _context.Clients select Client).OrderByDescending(x => x.NameC)
                .Skip(int.Parse(offset)).Take(int.Parse(limit));

            var result = await query.ToListAsync();

            if (result.Any() == false)
            {
                return NotFound();
            }

            return result;
        }

        [HttpGet("filter/")]
        public async Task<ActionResult<IEnumerable<Client>>> FilterClients([FromQuery] string Name,
           [FromQuery] string? name1,

           [FromQuery] string? idclien)

        {
            var query = _context.Clients.Where(act => true);

            if (idclien != null)
            {
                query = _context.Clients.Where(act => act.IdC == idclien);
            }

            if (Name != null)
            {
                query = _context.Clients.Where(act => act.NameC == name1);
            }


            var result = await query.ToListAsync();

            if (result.Any() == false)
            {
                return NotFound();
            }

            return result;
        }

        [HttpGet("paginated")]
        public async Task<ActionResult<IEnumerable<Client>>> GetClientPaginated([FromQuery] string limit,
          [FromQuery] string offset)
        {
            var query = (from Client in _context.Clients select Client).OrderByDescending(x => x.NameC)
                .Skip(int.Parse(offset)).Take(int.Parse(limit));

            return await _context.Clients.ToListAsync();
        }
    }
}