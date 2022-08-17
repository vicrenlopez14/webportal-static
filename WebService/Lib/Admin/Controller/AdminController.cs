using System.Net;
using Application.Models;
using Microsoft.AspNetCore.Mvc;
using WebService.Lib.Admin.DataSource;
using WebService.Lib.Global.Controller;
using WebService.Utils;

namespace WebService.Lib.Admin.Controller;

[Route("api/[controller]")]
[ApiController]
public class AdminController : CrudController<PFAdmin>
{
    private readonly AdminDataSource _dataSource = new();


    public override async Task<ActionResult<PFAdmin>> Get(string id)
    {
        PFAdmin? admin = await _dataSource.Get(id);
        return admin == null ? NotFound() : admin;
    }

    public override async Task<ActionResult<IEnumerable<PFAdmin>>> List()
    {
        var result = await _dataSource.List();
        return Ok(result);
    }

    public override Task<ActionResult<IEnumerable<PFAdmin>>> PaginatedList(int fromIndex, int? toIndex)
    {
        if (toIndex is null or -1) toIndex = fromIndex + 10;
        var result = _dataSource.PaginatedList(fromIndex, toIndex ?? -1);
        return Task.FromResult<ActionResult<IEnumerable<PFAdmin>>>(Ok(result));
    }

    [HttpGet("criteria")]
    public async Task<ActionResult<IEnumerable<PFAdmin>>> Search(string name)
    {
        Dictionary<string, string> searchCriteria = new()
        {
            ["Name"] = name
        };

        // Simple search
        var result = await _dataSource.Search(searchCriteria);
        return new ActionResult<IEnumerable<PFAdmin>>(Ok(result));
    }

    
    public override async Task<ActionResult<HttpStatusCode>> Create(PFAdmin newObject)
    {
        newObject.IdA = await Nanoid.Nanoid.GenerateAsync();
        newObject.PasswordA = SHAPassword.ShaThisPassword(newObject.PasswordA!);

        return (await _dataSource.Create(newObject) ? Ok(newObject) : NotFound());
    }

    [HttpPost("login")]
    public async Task<ActionResult<HttpStatusCode>> Login([FromBody] LoginAdmin loginAdmin)
    {
        return (await _dataSource.Login(loginAdmin.EmailA, loginAdmin.PasswordA)) ? Ok() : NotFound();
    }

    public override async Task<ActionResult<HttpStatusCode>> Update(string id, PFAdmin toUpdateObject)
    {
        return (await _dataSource.Update(id, toUpdateObject) ? Ok(toUpdateObject) : NotFound());
    }

    public override async Task<ActionResult<HttpStatusCode>> Delete(string id)
    {
        return Ok(await _dataSource.Delete(id));
    }
}