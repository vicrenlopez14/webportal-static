using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace ProFind_WebService.Lib.Global.Controller;

public abstract class CrudController<T> : ControllerBase
{
    [HttpGet("{id}")]
    public abstract Task<ActionResult<T>> Get(string id);

    [HttpGet]
    public abstract Task<ActionResult<IEnumerable<T>>> List();

    [HttpGet("paginated/{fromIndex:int}/{toIndex:int}")]
    public abstract Task<ActionResult<IEnumerable<T>>> PaginatedList(int fromIndex, int? toIndex);
    
    [HttpPost]
    public abstract Task<ActionResult<HttpStatusCode>> Create(T newObject);

    [HttpPut("{id}")]
    public abstract Task<ActionResult<HttpStatusCode>> Update(string id, T toUpdateObject);

    [HttpDelete("{id}")]
    public abstract Task<ActionResult<HttpStatusCode>> Delete(string id);
}