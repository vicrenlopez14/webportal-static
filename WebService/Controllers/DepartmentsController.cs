using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebService.Data;
using Department = WebService.Models.Generated.Department;

namespace WebService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DepartmentsController : ControllerBase
{
    private readonly ProFindContext _context;

    public DepartmentsController(ProFindContext context)
    {
        _context = context;
    }

    // GET: api/Departments
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Department>>> GetDepartments()
    {
        if (_context.Departments == null)
        {
            return NotFound();
        }
        return await _context.Departments.ToListAsync();
    }

    // GET: api/Departments/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Department>> GetDepartment(int id)
    {
        if (_context.Departments == null)
        {
            return NotFound();
        }
        var department = await _context.Departments.FindAsync(id);

        if (department == null)
        {
            return NotFound();
        }

        return department;
    }

    // PUT: api/Departments/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutDepartment(int id, Department department)
    {
        if (id != department.IdDp)
        {
            return BadRequest();
        }

        _context.Entry(department).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!DepartmentExists(id))
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

    // POST: api/Departments
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Department>> PostDepartment(Department department)
    {
        if (_context.Departments == null)
        {
            return Problem("Entity set 'ProFindContext.Departments'  is null.");
        }
        _context.Departments.Add(department);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetDepartment", new { id = department.IdDp }, department);
    }

    // DELETE: api/Departments/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDepartment(int id)
    {
        if (_context.Departments == null)
        {
            return NotFound();
        }
        var department = await _context.Departments.FindAsync(id);
        if (department == null)
        {
            return NotFound();
        }

        _context.Departments.Remove(department);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool DepartmentExists(int id)
    {
        return (_context.Departments?.Any(e => e.IdDp == id)).GetValueOrDefault();
    }
}