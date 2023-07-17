using System.ComponentModel.DataAnnotations;

namespace AppJhoBella.ApiUsuario.Data.Dto;

public class CreateUsuarioDto
{
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public DateTime DataNascimento { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string Senha { get; set; }
    [Required]
    [Compare("Senha")]
    public string ConfirmaSenha { get; set; }
}
