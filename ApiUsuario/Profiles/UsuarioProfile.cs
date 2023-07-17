using AppJhoBella.ApiUsuario.Data.Dto;
using AppJhoBella.ApiUsuario.Models;
using AutoMapper;

namespace AppJhoBella.ApiUsuario.Profiles;

public class UsuarioProfile : Profile
{
    public UsuarioProfile() 
    {
        CreateMap<CreateUsuarioDto, Usuario>();
    }
}
