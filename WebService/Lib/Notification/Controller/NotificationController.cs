using System.Net;
using Application.Models;
using Microsoft.AspNetCore.Mvc;
using WebService.Lib.Notification.DataSource;
using WebService.Lib.Global.Controller;

namespace WebService.Lib.Notification.Controller;

[Route("api/[controller]")]
public class NotificationController : CrudController<PFNotification>
{
    private readonly NotificationDataSource _dataSource = new();

    public override async Task<ActionResult<PFNotification>> Get(string id)
    {
        var result = await _dataSource.Get(id);
        return Ok(result);
    }

    public override async Task<ActionResult<IEnumerable<PFNotification>>> List()
    {
        var result = await _dataSource.List();
        return Ok(result);
    }

    public override async Task<ActionResult<IEnumerable<PFNotification>>> PaginatedList(int fromIndex, int? toIndex)
    {
        throw new NotImplementedException();
    }

    [HttpGet("criteria")]
    public async Task<ActionResult<IEnumerable<PFNotification>>> Search(IDictionary<string, string> searchCriteria)
    {
        var searchResult = await _dataSource.Search(searchCriteria);
        return (searchResult.Any() ? Ok(searchResult) : NotFound());
    }

    public override async Task<ActionResult<HttpStatusCode>> Create(PFNotification newObject)
    {
        newObject.IdN = await Nanoid.Nanoid.GenerateAsync();

        return (await _dataSource.Create(newObject) ? Ok(newObject) : NotFound());
    }

    public override async Task<ActionResult<HttpStatusCode>> Update(string id, PFNotification toUpdateObject)
    {
        return (await _dataSource.Update(id, toUpdateObject)) ? Ok(toUpdateObject) : NotFound();
    }

    public override async Task<ActionResult<HttpStatusCode>> Delete(string id)
    {
        return Ok(await _dataSource.Delete(id));
    }
}