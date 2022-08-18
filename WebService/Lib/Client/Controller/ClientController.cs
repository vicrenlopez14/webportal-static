using System.Net;
using Application.Models;
using Microsoft.AspNetCore.Mvc;
using WebService.Lib.Client.DataSource;
using WebService.Lib.Global.Controller;

namespace WebService.Lib.Client.Controller;

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
    public async Task<ActionResult<IEnumerable<PFClient>>> Search(IDictionary<string, string> searchCriteria)
    {
        throw new NotImplementedException();
    }

    public override async Task<ActionResult<HttpStatusCode>> Create(PFClient newObject)
    {
        newObject.IdC = await Nanoid.Nanoid.GenerateAsync();

        return await _dataSource.Create(newObject) ? Ok(newObject) : NotFound();
    }

    [HttpPost("login")]
    public async Task<ActionResult<HttpStatusCode>> Login(RegisterClient loginClient)
    {
        var (resultBool, resultObj) = await _dataSource.Login(loginClient.EmailC, loginClient.PasswordC);
        return (resultBool) ? Ok(resultObj) : NotFound();
    }

    [HttpPost("register")]
    public async Task<ActionResult<HttpStatusCode>> Register(RegisterClient registerClient)
    {
        var registerResponse =
            await _dataSource.Register(registerClient.NameC, registerClient.EmailC, registerClient.PasswordC,
                registerClient.PictureC);

        switch (registerResponse)
        {
            case RegisterResponse.Successful:
                return Ok();
            case RegisterResponse.AccountAlreadyExists:
                return Ok(HttpStatusCode.Conflict);
            case RegisterResponse.IncorrectPasswordFormat:
                return Ok(HttpStatusCode.BadRequest);
            default:
                return Ok(HttpStatusCode.InternalServerError);
        }
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