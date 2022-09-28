using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Microsoft.EntityFrameworkCore;
using Reporter.Data;
using RotativaCore;

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

    #region RegisteredAdmins

    public IActionResult PrintRegisteredAdmins()
    {
        return new ActionAsPdf("RegisteredAdmins")
        {
            FileName = "RegisteredAdmins.pdf"
        };
    }

    public async Task<IActionResult> RegisteredAdmins()
    {
        ViewData["admins"] = await _context.Admins.ToListAsync();
        return View();
    }

    #endregion

    public async Task<IActionResult> RegisteredProfessionals()
    {
        ViewData["professionals"] = await _context.Professionals.ToListAsync();
        return View();
    }


    #region RegisteredClients

    public ActionResult PrintRegisteredClients()
    {
        return new ActionAsPdf("RegisteredClients")
        {
            FileName = "RegisteredClients.pdf"
        };
    }

    public IActionResult RegisteredClients()
    {
        return View();
    }

    #endregion

    #region CreatedProjects

    public ActionResult PrintCreatedProjects()
    {
        return new ActionAsPdf("CreatedProjects")
        {
            FileName = "CreatedProjects.pdf"
        };
    }

    public async Task<IActionResult> CreatedProjects()
    {
        var projects = await _context.Projects.ToListAsync();

        ViewData["projects"] = projects;
        ViewData["totalprice"] = projects.Sum(p => p.TotalPricePj);

        return View();
    }

    #endregion CreatedProjects

    #region ProjectDetail

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

    #endregion
}