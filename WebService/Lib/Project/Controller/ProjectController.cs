using System.Net;
using Application.Models;
using Microsoft.AspNetCore.Mvc;
using WebService.Lib.Global.Controller;
using WebService.Lib.Project.DataSource;

namespace WebService.Lib.Project.Controller;

[Route("api/[controller]")]
public class ProjectController : CrudController<PFProject>
{
    private readonly ProjectDataSource _dataSource = new();

    public override async Task<ActionResult<PFProject>> Get(string id)
    {
        var result = await _dataSource.Get(id);
        return Ok(result);
    }

    public override async Task<ActionResult<IEnumerable<PFProject>>> List()
    {
        var result = await _dataSource.List();
        return Ok(result);
    }

    public override async Task<ActionResult<IEnumerable<PFProject>>> PaginatedList(int fromIndex, int? toIndex)
    {
        throw new NotImplementedException();
    }

    [HttpGet("criteria")]
    public async Task<ActionResult<IEnumerable<PFProject>>> Search(IDictionary<string, string> searchCriteria)
    {
        throw new NotImplementedException();
    }

    public override async Task<ActionResult<HttpStatusCode>> Create([FromBody] PFProject newObject)
    {
        newObject.IdPJ = await Nanoid.Nanoid.GenerateAsync();

        return await _dataSource.Create(newObject) ? Ok(newObject) : NotFound();
    }

    public override async Task<ActionResult<HttpStatusCode>> Update(string id, PFProject toUpdateObject)
    {
        return (await _dataSource.Update(id, toUpdateObject)) ? Ok(toUpdateObject) : NotFound();
    }

    public override async Task<ActionResult<HttpStatusCode>> Delete(string id)
    {
        return Ok(await _dataSource.Delete(id));
    }
}