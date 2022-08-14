using System.Net;
using Microsoft.AspNetCore.Mvc;
using ProFind_WebService.Lib.Global.Controller;
using Domain.Models;
using ProFind_WebService.Lib.Profession.DataSource;

namespace ProFind_WebService.Lib.Profession.Controller;

[Route("api/[controller]")]
[ApiController]
public class ProfessionController : CrudController<PFProfession>
{
    private readonly ProfessionDataSource _dataSource = new();

    public override async Task<ActionResult<PFProfession>> Get(string id)
    {
        var result = await _dataSource.Get(id);
        return Ok(result);
    }

    public override async Task<ActionResult<IEnumerable<PFProfession>>> List()
    {
        var result = await _dataSource.List();
        return Ok(result);
    }

    public override async Task<ActionResult<IEnumerable<PFProfession>>> PaginatedList(int fromIndex, int? toIndex)
    {
        throw new NotImplementedException();
    }

    [HttpGet("criteria")]
    public async Task<ActionResult<IEnumerable<PFProfession>>> Search(IDictionary<string, string> searchCriteria)
    {
        throw new NotImplementedException();
    }

    public override async Task<ActionResult<HttpStatusCode>> Create(PFProfession newObject)
    {
        throw new Exception();
    }

    public override async Task<ActionResult<HttpStatusCode>> Update(string id, PFProfession toUpdateObject)
    {
        return (await _dataSource.Update(id, toUpdateObject)) ? Ok(toUpdateObject) : NotFound();
    }

    public override async Task<ActionResult<HttpStatusCode>> Delete(string id)
    {
        return Ok(await _dataSource.Delete(id));
    }
}