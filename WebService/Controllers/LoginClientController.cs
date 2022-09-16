using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using WebService.Data;
using WebService.Models.Generated;

namespace WebService.Controllers;

public class ClientLogin
{
    public string Email { get; set; }
    public string Password { get; set; }
}

[Route("api/[controller]")]
[ApiController]
public class LoginClientController : ControllerBase
{
    private readonly ProFindContext _context;
    private readonly IConfiguration _config;

    public LoginClientController(IConfiguration config, ProFindContext context)
    {
        _config = config;
        _context = context;
    }

    [AllowAnonymous]
    [HttpPost]
    public ActionResult Login([FromBody] ClientLogin clientLogin)
    {
        var client = Authenticate(clientLogin);
        if (client != null)
        {
            var token = GenerateToken(client);
            return Ok(token);
        }

        return NotFound("user not found");
    }

    private string GenerateToken(Client client)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
        var claims = new[]
        {
            new Claim(ClaimTypes.Email, client.EmailC!),
            new Claim(ClaimTypes.Role, client.GetType().Name)
        };
        var token = new JwtSecurityToken(_config["Jwt:Issuer"], _config["Jwt:Audience"], claims,
            expires: DateTime.Now.AddMinutes(30), signingCredentials: credentials);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    private Client Authenticate(ClientLogin clientLogin)
    {
        var currentUser = _context.Clients.FirstOrDefault(x =>
            x.EmailC!.ToLower() == clientLogin.Email.ToLower() &&
            x.PasswordC == Utils.ShaOperations.ShaPassword(clientLogin.Password));

        return currentUser!;
    }
}