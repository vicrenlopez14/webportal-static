using System.Net;
using Application.Models;
using Microsoft.AspNetCore.Mvc;
using WebService.Lib.Department.DataSource;
using WebService.Lib.Global.Controller;

namespace WebService.Lib.Department.Controller;

[Route("api/[controller]")]
public class DepartmentController : CrudController<PFDepartment>
{
    private readonly DepartmentDataSource _dataSource = new();

    public override async Task<ActionResult<PFDepartment>> Get(string id)
    {
        var result = await _dataSource.Get(id);
        return Ok(result);
    }

    public override async Task<ActionResult<IEnumerable<PFDepartment>>> List()
    {
        var result = await _dataSource.List();
        return Ok(result);
    }

    public override async Task<ActionResult<IEnumerable<PFDepartment>>> PaginatedList(int fromIndex, int? toIndex)
    {
        throw new NotImplementedException();
    }

    [HttpGet("criteria")]
    public async Task<ActionResult<IEnumerable<PFDepartment>>> Search(IDictionary<string, string> searchCriteria)
    {
        throw new NotImplementedException();
    }

    public override async Task<ActionResult<HttpStatusCode>> Create(PFDepartment newObject)
    {
        throw new Exception();
    }

    public override async Task<ActionResult<HttpStatusCode>> Update(string id, PFDepartment toUpdateObject)
    {
        return (await _dataSource.Update(id, toUpdateObject)) ? Ok(toUpdateObject) : NotFound();
    }

    public override async Task<ActionResult<HttpStatusCode>> Delete(string id)
    {
        return Ok(await _dataSource.Delete(id));
    }
}