using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Reporter.Data;

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

    public IActionResult RegisteredAdmins()
    {
        ViewData["admins"] = _context.Admins.ToList();
        return View();
    }

    public IActionResult RegisteredProfessionals()
    {
        ViewData["professionals"] = _context.Professionals.ToList();
        return View();
    }

    public IActionResult RegisteredClients()
    {
        return View();
    }

    public IActionResult CreatedProjects()
    {
        return View();
    }
}