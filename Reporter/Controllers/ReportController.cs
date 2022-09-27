using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Microsoft.EntityFrameworkCore;
using Reporter.Data;
using Rotativa.NetCore;

namespace Reporter.Controllers;

public class ReportController : Controller
{
    private readonly ProFindContext _context;

    public ReportController(ProFindContext context)
    {
        _context = context;
    }


    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }

    // 
    // GET: /HelloWorld/Welcome/ 
    public string Welcome(string name, int ID = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }

    public async Task<IActionResult> RegisteredAdmins()
    {
        ViewData["admins"] = await _context.Admins.ToListAsync();
        return View();
    }

    public async Task<IActionResult> RegisteredProfessionals()
    {
        ViewData["professionals"] = await _context.Professionals.ToListAsync();
        return View();
    }

    public IActionResult RegisteredClients()
    {
        return View();
    }

    public async Task<IActionResult> CreatedProjects()
    {
        var projects = await _context.Projects.ToListAsync();

        ViewData["projects"] = projects;
        ViewData["totalprice"] = projects.Sum(p => p.TotalPricePj);

        return View();
    }

    public ActionResult PrintProjectDetail(string id)
    {
        return new ActionAsPdf("ProjectDetail", new { id })
        {
            FileName = "ProjectDetail.pdf"
        };
    }

    // Project
    public async Task<IActionResult> ProjectDetail(string id)
    {
        ViewBag.id = "";

        var selectedProject = await _context.Projects.FirstOrDefaultAsync(p => p.IdPj == id);
        ViewData["project"] = selectedProject;

        return View();
    }
}