using System.Net;
using Microsoft.AspNetCore.Mvc;
using ProFind_WebService.Lib.Admin.DataSource;
using ProFind_WebService.Lib.Admin.Model;
using ProFind_WebService.Lib.Global.Controller;

namespace ProFind_WebService.Lib.Admin.Controller;

[Route("api/[controller]")]
[ApiController]
public class AdminController : CrudController<PFAdmin>
{
    public override async Task<ActionResult<PFAdmin>> Get(string id)
    {
        PFAdmin admin = await dataSource.Get(id);
        return admin == null ? NotFound() : admin;
    }

    public override async Task<ActionResult<IEnumerable<PFAdmin>>> List()
    {
        var result = dataSource.List();
        return (result==null ? NotFound():result);
    }

    public override async Task<ActionResult<IEnumerable<PFAdmin>>> PaginatedList(int fromIndex, int? toIndex)
    {
        if(toIndex is null or -1) toIndex = fromIndex+10;
        var result=dataSource.PaginatedList(fromIndex,toIndex);
        return (result==null ? NotFound():result);
    }

    public override async Task<ActionResult<IEnumerable<PFAdmin>>> Search(IDictionary<string, string> searchCriteria)
    {
        throw new NotImplementedException();
    }

    public override async Task<ActionResult<HttpStatusCode>> Create(PFAdmin newObject)
    {
        return (await dataSource.Create(newObject) ? Ok(newObject) : NotFound());
    }

    public override async Task<ActionResult<HttpStatusCode>> Update(PFAdmin toUpdateObject)
    {
        return (await dataSource.Update(toUpdateObject) ? Ok(toUpdateObject) : NotFound()); 
    }

    public override async Task<ActionResult<HttpStatusCode>> Delete(string id)
    {
        PFAdmin admin = new PFAdmin(id);
        return (await dataSource.Delete(admin) ? Ok(admin) : NotFound());
    }
}