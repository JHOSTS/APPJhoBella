using Microsoft.AspNetCore.Identity;

namespace AppJhoBella.ApiUsuario.Models;

public class Usuario : IdentityUser
{
    public DateTime DataNascimento { get; set; }
    public Usuario() : base() { }
}
