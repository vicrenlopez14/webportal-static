using System.Net;
using Application.Models;
using Microsoft.AspNetCore.Mvc;
using ProFind_WebService.Lib.Global.Controller;
using ProFind_WebService.Lib.Activity.DataSource;

namespace ProFind_WebService.Lib.Activity.Controller;

[Route("api/[controller]")]
public class ActivityController : CrudController<PFActivity>
{
    private readonly ActivityDataSource _dataSource = new();

    public override async Task<ActionResult<PFActivity>> Get(string id)
    {
        var result = await _dataSource.Get(id);
        return Ok(result);
    }

    public override async Task<ActionResult<IEnumerable<PFActivity>>> List()
    {
        var result = await _dataSource.List();
        return Ok(result);
    }

    public override async Task<ActionResult<IEnumerable<PFActivity>>> PaginatedList(int fromIndex, int? toIndex)
    {
        throw new NotImplementedException();
    }

    [HttpGet("criteria")]
    public async Task<ActionResult<IEnumerable<PFActivity>>> Search(IDictionary<string, string> searchCriteria)
    {
        var searchResult = await _dataSource.Search(searchCriteria);
        return (searchResult.Any() ? Ok(searchResult) : NotFound());
    }

    public override async Task<ActionResult<HttpStatusCode>> Create(PFActivity newObject)
    {
        newObject.IdA = await Nanoid.Nanoid.GenerateAsync();

        return (await _dataSource.Create(newObject) ? Ok(newObject) : NotFound());
    }

    public override async Task<ActionResult<HttpStatusCode>> Update(string id, PFActivity toUpdateObject)
    {
        return (await _dataSource.Update(id, toUpdateObject)) ? Ok(toUpdateObject) : NotFound();
    }

    public override async Task<ActionResult<HttpStatusCode>> Delete(string id)
    {
        return Ok(await _dataSource.Delete(id));
    }
}