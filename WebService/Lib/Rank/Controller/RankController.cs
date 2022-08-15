using System.Net;
using Application.Models;
using Microsoft.AspNetCore.Mvc;
using WebService.Lib.Global.Controller;
using WebService.Lib.Rank.DataSource;

namespace WebService.Lib.Rank.Controller;

[Route("api/[controller]")]
[ApiController]
public class RankController : CrudController<PFRank>
{

    private readonly RankDataSource _dataSource = new();

    public override async Task<ActionResult<PFRank>> Get(string id)
    {
        var result = await _dataSource.Get(id);
        return Ok(result);
    }

    public override async Task<ActionResult<IEnumerable<PFRank>>> List()
    {
        var result = await _dataSource.List();
        return Ok(result);
    }

    public override async Task<ActionResult<IEnumerable<PFRank>>> PaginatedList(int fromIndex, int? toIndex)
    {
        throw new NotImplementedException();
    }

    [HttpGet("criteria")]

    public  async Task<ActionResult<IEnumerable<PFRank>>> Search(IDictionary<string, string> searchCriteria)
    {
        throw new NotImplementedException();
    }

    public override async Task<ActionResult<HttpStatusCode>> Create(PFRank newObject)
    {
        newObject.IdR = Nanoid.Nanoid.Generate();
        return (await _dataSource.Create(newObject)) ? Ok(newObject) : NotFound();
    }

    public override async Task<ActionResult<HttpStatusCode>> Update(string id, PFRank toUpdateObject)
    {
        return (await _dataSource.Update(id, toUpdateObject)) ? Ok(toUpdateObject) : NotFound();
    }

    public override async Task<ActionResult<HttpStatusCode>> Delete(string id)
    {
        return Ok(await _dataSource.Delete(id));
    }
}