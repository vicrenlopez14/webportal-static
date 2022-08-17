using System.Net;
using Application.Models;
using Microsoft.AspNetCore.Mvc;
using WebService.Lib.Global.Controller;
using WebService.Lib.Professional.DataSource;

namespace WebService.Lib.Professional.Controller;

[Route("api/[controller]")]
[ApiController]
public class ProfessionalController : CrudController<PFProfessional>
{
    private readonly ProfessionalDataSource _dataSource = new();

    public override async Task<ActionResult<PFProfessional>> Get(string id)
    {
        var result = await _dataSource.Get(id);
        return Ok(result);
    }

    public override async Task<ActionResult<IEnumerable<PFProfessional>>> List()
    {
        var result = await _dataSource.List();
        return Ok(result);
    }

    public override async Task<ActionResult<IEnumerable<PFProfessional>>> PaginatedList(int fromIndex,
        int? toIndex)
    {
        throw new NotImplementedException();
    }

    [HttpGet("criteria")]
    public async Task<ActionResult<IEnumerable<PFProfessional>>> Search(
        IDictionary<string, string> searchCriteria)
    {
        throw new NotImplementedException();
    }

    public override async Task<ActionResult<HttpStatusCode>> Create(PFProfessional newObject)
    {
        newObject.IdP = await Nanoid.Nanoid.GenerateAsync();
        return (await _dataSource.Create(newObject)) ? Ok(newObject) : NotFound();
    }

    [HttpPost("login")]
    public async Task<ActionResult<HttpStatusCode>> Login(LoginProfessional loginProfessional)
    {
        return (await _dataSource.Login(loginProfessional.EmailP, loginProfessional.PasswordP)) ? Ok() : NotFound();
    }

    public override async Task<ActionResult<HttpStatusCode>> Update(string id, PFProfessional toUpdateObject)
    {
        return (await _dataSource.Update(id, toUpdateObject)) ? Ok(toUpdateObject) : NotFound();
    }

    public override async Task<ActionResult<HttpStatusCode>> Delete(string id)
    {
        return Ok(await _dataSource.Delete(id));
    }
}