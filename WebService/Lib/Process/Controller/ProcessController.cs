using System.Net;
using Application.Models;
using Microsoft.AspNetCore.Mvc;
using WebService.Lib.Global.Controller;
using WebService.Lib.Process.DataSource;

namespace WebService.Lib.Process.Controller;

[Route("api/[controller]")]
[ApiController]
public class ProcessController : CrudController<PFProcess>
{

    private readonly ProcessDataSource _dataSource = new();

    public override async Task<ActionResult<PFProcess>> Get(string id)
    {
        var result = await _dataSource.Get(id);
        return Ok(result);
    }

    public override async Task<ActionResult<IEnumerable<PFProcess>>> List()
    {
        var result = await _dataSource.List();
        return Ok(result);
    }

    public override async Task<ActionResult<IEnumerable<PFProcess>>> PaginatedList(int fromIndex, int? toIndex)
    {
        throw new NotImplementedException();
    }

    [HttpGet("criteria")]
    public  async Task<ActionResult<IEnumerable<PFProcess>>> Search(IDictionary<string, string> searchCriteria)
    {
        throw new NotImplementedException();
    }

    public override async Task<ActionResult<HttpStatusCode>> Create(PFProcess newObject)
    {
        newObject.IdPR = await Nanoid.Nanoid.GenerateAsync();
        return (await _dataSource.Create(newObject)) ? Ok(newObject) : NotFound();
    }

    public override async Task<ActionResult<HttpStatusCode>> Update(string id, PFProcess toUpdateObject)
    {
        return (await _dataSource.Update(id, toUpdateObject)) ? Ok(toUpdateObject) : NotFound();
    }

    public override async Task<ActionResult<HttpStatusCode>> Delete(string id)
    {
        return Ok(await _dataSource.Delete(id));
    }
}