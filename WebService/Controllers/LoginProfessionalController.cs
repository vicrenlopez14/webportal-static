using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using WebService.Data;
using WebService.Models.Generated;

namespace WebService.Controllers;

public class ProfessionalLogin
{
    public string Email { get; set; }
    public string Password { get; set; }
}

[Route("api/[controller]")]
[ApiController]
public class LoginProfessionalController : ControllerBase
{
    private readonly ProFindContext _context;
    private readonly IConfiguration _config;

    public LoginProfessionalController(IConfiguration config, ProFindContext context)
    {
        _config = config;
        _context = context;
    }

    [AllowAnonymous]
    [HttpPost]
    public ActionResult Login([FromBody] ProfessionalLogin professionalLogin)
    {
        var professional = Authenticate(professionalLogin);
        if (professional != null)
        {
            var token = GenerateToken(professional);
            return Ok(token);
        }

        return NotFound("user not found");
    }

    private string GenerateToken(Professional professional)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
        var claims = new[]
        {
            new Claim(ClaimTypes.Email, professional.EmailP!),
            new Claim(ClaimTypes.Role, professional.GetType().Name)
        };
        var token = new JwtSecurityToken(_config["Jwt:Issuer"], _config["Jwt:Audience"], claims,
            expires: DateTime.Now.AddMinutes(30), signingCredentials: credentials);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    private Professional Authenticate(ProfessionalLogin professionalLogin)
    {
        var currentUser = _context.Professionals.FirstOrDefault(x =>
            x.EmailP!.ToLower() == professionalLogin.Email.ToLower() &&
            x.PasswordP == Utils.ShaOperations.ShaPassword(professionalLogin.Password));

        return currentUser!;
    }
}