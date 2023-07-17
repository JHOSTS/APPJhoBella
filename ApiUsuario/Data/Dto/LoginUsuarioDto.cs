using System.ComponentModel.DataAnnotations;

namespace AppJhoBella.ApiUsuario.Data.Dto;

public class LoginUsuarioDto
{
    [Required]
    public string Usuario { get; set; }
    [Required]
    public string Senha { get; set; }
}
