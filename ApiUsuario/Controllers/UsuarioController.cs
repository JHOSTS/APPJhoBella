﻿using AppJhoBella.ApiUsuario.Data.Dto;
using AppJhoBella.ApiUsuario.Services;
using Microsoft.AspNetCore.Mvc;

namespace AppJhoBella.ApiUsuario.Controllers;
[ApiController]
[Route("[Controller]")]
public class UsuarioController : ControllerBase
{
    private UsuarioService _usuarioService;

    public UsuarioController(UsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    [HttpPost("cadastro")]
    public async Task<IActionResult> CadastraUsuario(CreateUsuarioDto dto)
    {
        await _usuarioService.Cadastro(dto);
        return Ok("Usuário cadastrado!");
    }
    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginUsuarioDto dto)
    {
        var token = await _usuarioService.Login(dto);
        return Ok(token);
    }
}
