using System.Net;
using Microsoft.AspNetCore.Mvc;
using ProFind_WebService.Lib.Client.Model;
using ProFind_WebService.Lib.Global.Controller;
using ProFind_WebService.Lib.Client.DataSource;

namespace ProFind_WebService.Lib.Client.Controller;

[Route("api/[controller]")]
[ApiController]
public class ClientController : CrudController<PFClient>
{

    private readonly ClientDataSource _dataSource = new();

    public override async Task<ActionResult<PFClient>> Get(string id)
    {
        PFClient client = await _dataSource.Get(id);
        return Ok(client);
    }

    public override async Task<ActionResult<IEnumerable<PFClient>>> List()
    {
        var result = await _dataSource.List();
        return Ok(result);
    }

    public override async Task<ActionResult<IEnumerable<PFClient>>> PaginatedList(int fromIndex, int? toIndex)
    {
        throw new NotImplementedException();
    }

    [HttpGet("criteria")]

    public  async Task<ActionResult<IEnumerable<PFClient>>> Search(IDictionary<string, string> searchCriteria)
    {
        throw new NotImplementedException();
    }

    public override async Task<ActionResult<HttpStatusCode>> Create(PFClient newObject)
    {
        newObject.IdC = Nanoid.Nanoid.Generate();
        return await _dataSource.Create(newObject) ? Ok(newObject) : NotFound(); 
    }

    public override async Task<ActionResult<HttpStatusCode>> Update(string id, PFClient toUpdateObject)
    {
        return await _dataSource.Update(id, toUpdateObject) ? Ok(toUpdateObject) : NotFound();
    }

    public override async Task<ActionResult<HttpStatusCode>> Delete(string id)
    {
        return Ok(await _dataSource.Delete(id));
    }
}