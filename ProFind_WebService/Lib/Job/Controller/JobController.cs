using System.Net;
using Microsoft.AspNetCore.Mvc;
using ProFind_WebService.Lib.Global.Controller;
using Domain.Models;
using ProFind_WebService.Lib.Job.DataSource;

namespace ProFind_WebService.Lib.Job.Controller;

[Route("api/[controller]")]
[ApiController]
public class JobController : CrudController<PFJob>
{

    private readonly JobDataSource _dataSource = new();

    public override async Task<ActionResult<PFJob>> Get(string id)
    {
        var result = await _dataSource.Get(id);
        return Ok(result);
    }

    public override async Task<ActionResult<IEnumerable<PFJob>>> List()
    {
        var result = await _dataSource.List();
        return Ok(result);
    }

    public override async Task<ActionResult<IEnumerable<PFJob>>> PaginatedList(int fromIndex, int? toIndex)
    {
        throw new NotImplementedException();
    }

        [HttpGet("criteria")]

    public  async Task<ActionResult<IEnumerable<PFJob>>> Search(IDictionary<string, string> searchCriteria)
    {
        throw new NotImplementedException();
    }

    public override async Task<ActionResult<HttpStatusCode>> Create(PFJob newObject)
    {
        newObject.IdJ = Nanoid.Nanoid.Generate();
        return (await _dataSource.Create(newObject)) ? Ok(newObject) : NotFound();
    }

    public override async Task<ActionResult<HttpStatusCode>> Update(string id, PFJob toUpdateObject)
    {
        return (await _dataSource.Update(id, toUpdateObject)) ? Ok(toUpdateObject) : NotFound();
    }

    public override async Task<ActionResult<HttpStatusCode>> Delete(string id)
    {
        return Ok(await _dataSource.Delete(id));
    }
}