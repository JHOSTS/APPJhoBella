using AppJhoBella.ApiUsuario.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AppJhoBella.ApiUsuario.Services;

public class TokenService
{
    private IConfiguration _configuration;

    public TokenService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string GenerateToken(Usuario usuario)
    {
        Claim[] claims = new Claim[]
        {
            new Claim("usuario", usuario.UserName),
            new Claim("id", usuario.Id)
        };

        var chave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("KSKSAKSASKASKKSAASK"));

        var signinCredentials = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken
            (
            expires: DateTime.Now.AddMinutes(30),
            claims: claims,
            signingCredentials: signinCredentials
            );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
