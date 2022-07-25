using System.Net;
using Microsoft.AspNetCore.Mvc;
using ProFind_WebService.Lib.Curriculum.Model;
using ProFind_WebService.Lib.Global.Controller;
using ProFind_WebService.Lib.Curriculum.DataSource;

namespace ProFind_WebService.Lib.Curriculum.Controller;

[Route("api/[controller]")]
[ApiController]
public class CurriculumController : CrudController<PFCurriculum>
{

    private readonly CurriculumDataSource _dataSource = new();

    public override async Task<ActionResult<PFCurriculum>> Get(string id)
    {
        var result = await _dataSource.Get(id);
        return Ok(result);
    }

    public override async Task<ActionResult<IEnumerable<PFCurriculum>>> List()
    {
        var result = await _dataSource.List();
        return Ok(result);
    }

    public override async Task<ActionResult<IEnumerable<PFCurriculum>>> PaginatedList(int fromIndex, int? toIndex)
    {
        throw new NotImplementedException();
    }

    [HttpGet("criteria")]
    public  async Task<ActionResult<IEnumerable<PFCurriculum>>> Search(
        IDictionary<string, string> searchCriteria)
    {
        throw new NotImplementedException();
    }

    public override async Task<ActionResult<HttpStatusCode>> Create(PFCurriculum newObject)
    {
        newObject.IdCU = Nanoid.Nanoid.Generate();
        return (await _dataSource.Create(newObject)) ? Ok(newObject) : NotFound();
    }

    public override async Task<ActionResult<HttpStatusCode>> Update(string id, PFCurriculum toUpdateObject)
    {
        return (await _dataSource.Update(id, toUpdateObject)) ? Ok(toUpdateObject) : NotFound();
    }

    public override async Task<ActionResult<HttpStatusCode>> Delete(string id)
    {
        return Ok(_dataSource.Delete(id));
    }
}