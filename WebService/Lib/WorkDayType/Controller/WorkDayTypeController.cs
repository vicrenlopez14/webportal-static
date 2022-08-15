using System.Net;
using Application.Models;
using Microsoft.AspNetCore.Mvc;
using WebService.Lib.Global.Controller;
using WebService.Lib.WorkDayType.DataSource;

namespace WebService.Lib.WorkDayType.Controller;

[Route("api/[controller]")]
public class WorkDayTypeController : CrudController<PFWorkDayType>
{
    private readonly WorkDayTypeDataSource _dataSource = new();

    public override async Task<ActionResult<PFWorkDayType>> Get(string id)
    {
        var result = await _dataSource.Get(id);
        return Ok(result);
    }

    public override async Task<ActionResult<IEnumerable<PFWorkDayType>>> List()
    {
        var result = await _dataSource.List();
        return Ok(result);
    }

    public override async Task<ActionResult<IEnumerable<PFWorkDayType>>> PaginatedList(int fromIndex, int? toIndex)
    {
        throw new NotImplementedException();
    }

    [HttpGet("criteria")]
    public async Task<ActionResult<IEnumerable<PFWorkDayType>>> Search(IDictionary<string, string> searchCriteria)
    {
        throw new NotImplementedException();
    }

    public override async Task<ActionResult<HttpStatusCode>> Create(PFWorkDayType newObject)
    {
        return (await _dataSource.Create(newObject)) ? Ok(newObject) : NotFound();
    }

    public override async Task<ActionResult<HttpStatusCode>> Update(string id, PFWorkDayType toUpdateObject)
    {
        return (await _dataSource.Update(id, toUpdateObject)) ? Ok(toUpdateObject) : NotFound();
    }

    public override async Task<ActionResult<HttpStatusCode>> Delete(string id)
    {
        return Ok(await _dataSource.Delete(id));
    }
}