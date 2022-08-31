using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebService.Data;
using WebService.Models;
using Admin = WebService.Models.Generated.Admin;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        private readonly ProFindContext _context;

        public AdminsController(ProFindContext context)
        {
            _context = context;
        }

        // Register an Admin method
        // POST: api/Admins/Register
        [HttpPost("Register")]
        public async Task<IActionResult> RegisterAdmin(Admin admin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(admin);
                await _context.SaveChangesAsync();
                return Ok(admin);
            }

            return BadRequest(ModelState);
        }

        // Login an Admin method
        // POST: api/Admins/Login
        [HttpPost("Login")]
        public async Task<IActionResult> LoginAdmin(Admin admin)
        {
            if (ModelState.IsValid)
            {
                var adminFromDb =
                    await _context.Admins.FirstOrDefaultAsync(a =>
                        a.EmailA == admin.EmailA && a.PasswordA == admin.PasswordA);
                if (adminFromDb != null)
                {
                    return Ok(adminFromDb);
                }
            }

            return BadRequest(ModelState);
        }


        // GET: api/Admins
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Admin>>> GetAdmins()
        {
            if (_context.Admins == null)
            {
                return NotFound();
            }

            return await _context.Admins.ToListAsync();
        }

        // GET: api/Admins/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Admin>> GetAdmin(string id)
        {
            if (_context.Admins == null)
            {
                return NotFound();
            }

            var admin = await _context.Admins.FindAsync(id);

            if (admin == null)
            {
                return NotFound();
            }

            return admin;
        }

        // PUT: api/Admins/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdmin(string id, Admin admin)
        {
            if (id != admin.IdA)
            {
                return BadRequest();
            }

            _context.Entry(admin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdminExists(id))
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

        // POST: api/Admins
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Admin>> PostAdmin(Admin admin)
        {
            if (_context.Admins == null)
            {
                return Problem("Entity set 'ProFindContext.Admins'  is null.");
            }

            _context.Admins.Add(admin);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AdminExists(admin.IdA))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAdmin", new { id = admin.IdA }, admin);
        }

        // DELETE: api/Admins/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdmin(string id)
        {
            if (_context.Admins == null)
            {
                return NotFound();
            }

            var admin = await _context.Admins.FindAsync(id);
            if (admin == null)
            {
                return NotFound();
            }

            _context.Admins.Remove(admin);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AdminExists(string id)
        {
            return (_context.Admins?.Any(e => e.IdA == id)).GetValueOrDefault();
        }

        [HttpGet("search/")]
        public async Task<ActionResult<IEnumerable<Admin>>> SearcAdmins([FromQuery] string idA,
          [FromQuery] string Name)
        {
            var result = await (from Admins in _context.Admins
                                where (Admins.IdA == idA && Admins.NameA.Contains(Name))
                                select Admins).ToListAsync();

            if (result.Any() == false)
            {
                return NotFound();
            }

            return result;
        }

        [HttpGet("search/paginated")]
        public async Task<ActionResult<IEnumerable<Admin>>> SearchAdmins([FromQuery] string idA,
           [FromQuery] string Name, [FromQuery] string limit,
           [FromQuery] string offset)
        {
            var query = (from admin in _context.Admins
                         where (admin.IdA == idA && admin.NameA.Contains(Name))
                         select admin);

            query = (from Admin in _context.Admins select Admin).OrderByDescending(x => x.NameA)
                .Skip(int.Parse(offset)).Take(int.Parse(limit));

            var result = await query.ToListAsync();

            if (result.Any() == false)
            {
                return NotFound();
            }

            return result;
        }
        [HttpGet("filter/")]
        public async Task<ActionResult<IEnumerable<Admin>>> FilterAdmins([FromQuery] string Name,
           [FromQuery] string? name1,

           [FromQuery] string? idAdmin)

        {
            var query = _context.Admins.Where(act => true);

            if (idAdmin != null)
            {
                query = _context.Admins.Where(act => act.IdA == idAdmin);
            }

            if (Name != null)
            {
                query = _context.Admins.Where(act => act.NameA == name1);
            }


            var result = await query.ToListAsync();

            if (result.Any() == false)
            {
                return NotFound();
            }

            return result;
        }

        [HttpGet("paginated")]
        public async Task<ActionResult<IEnumerable<Admin>>> GetAdminsPaginated([FromQuery] string limit,
           [FromQuery] string offset)
        {
            var query = (from activity in _context.Admins select activity).OrderByDescending(x => x.NameA)
                .Skip(int.Parse(offset)).Take(int.Parse(limit));

            return await _context.Admins.ToListAsync();
        }
    }
}