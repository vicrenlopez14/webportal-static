using System.Net;
using Microsoft.AspNetCore.Mvc;
using ProFind_WebService.Lib.Admin.Model;

namespace ProFind_WebService.Lib.Global.Controller;

public interface CRUD_Controller <T>
{
    public Task<ActionResult<T>> Get<TE>(TE identifier);

    public Task<ActionResult<IEnumerable<T>>> List<TE>(TE identifier);
    
    public Task<ActionResult<HttpStatusCode>> Post(T newObject);

    public Task<HttpStatusCode> DeleteController(string id);
}