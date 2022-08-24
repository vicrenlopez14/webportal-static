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

    [HttpGet("user/{id}")]
    public async Task<ActionResult<IEnumerable<PFProject>>> GetUserProjects(string id)
    {
        var result = await _dataSource.GetProjectsOfAClient(id);
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

    // Method to get the projects that have a IdPS1 value of 3 named GetProposalProjects
    [HttpGet("proposal")]
    public async Task<ActionResult<IEnumerable<PFProject>>> GetProposalProjects()
    {
        var result = await _dataSource.GetProposalProjects();
        return Ok(result);
    }
    
    public override async Task<ActionResult<HttpStatusCode>> Update(string id, [FromBody] PFProject toUpdateObject)
    {
        return (await _dataSource.Update(id, toUpdateObject)) ? Ok(toUpdateObject) : NotFound();
    }

    public override async Task<ActionResult<HttpStatusCode>> Delete(string id)
    {
        return Ok(await _dataSource.Delete(id));
    }
}