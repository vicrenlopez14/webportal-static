using System.Net;
using Application.Models;
using Microsoft.AspNetCore.Mvc;
using ProFind_WebService.Lib.Global.Controller;
using ProFind_WebService.Lib.ProjectStatus.DataSource;

namespace ProFind_WebService.Lib.ProjectStatus.Controller;

[Route("api/[controller]")]
public class ProjectStatusController : CrudController<PFProjectStatus>
{
    private readonly ProjectStatusDataSource _dataSource = new();

    public override async Task<ActionResult<PFProjectStatus>> Get(string id)
    {
        var result = await _dataSource.Get(id);
        return Ok(result);
    }

    public override async Task<ActionResult<IEnumerable<PFProjectStatus>>> List()
    {
        var result = await _dataSource.List();
        return Ok(result);
    }

    public override async Task<ActionResult<IEnumerable<PFProjectStatus>>> PaginatedList(int fromIndex, int? toIndex)
    {
        throw new NotImplementedException();
    }

    [HttpGet("criteria")]
    public async Task<ActionResult<IEnumerable<PFProjectStatus>>> Search(IDictionary<string, string> searchCriteria)
    {
        throw new NotImplementedException();
    }

    public override async Task<ActionResult<HttpStatusCode>> Create(PFProjectStatus newObject)
    {
        throw new Exception();
    }

    public override async Task<ActionResult<HttpStatusCode>> Update(string id, PFProjectStatus toUpdateObject)
    {
        return (await _dataSource.Update(id, toUpdateObject)) ? Ok(toUpdateObject) : NotFound();
    }

    public override async Task<ActionResult<HttpStatusCode>> Delete(string id)
    {
        return Ok(await _dataSource.Delete(id));
    }
}