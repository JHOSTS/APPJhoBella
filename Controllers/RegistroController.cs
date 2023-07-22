using AppJhoBella.ApiUsuario.Data.Dto;
using AppJhoBella.ApiUsuario.Services;
using AppJhoBella.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace AppJhoBella.Controllers
{
    public class RegistroController : Controller
    {
        private UsuarioService _usuarioService;
        private  ILogger<RegistroController> _logger;

        public async Task<IActionResult> CadastraUsuario(CreateUsuarioDto dto)
        {
            if(!ModelState.IsValid) return Registro();

            await _usuarioService.Cadastro(dto);
            return Redirect("/Login");
        }
        public IActionResult Registro()
        {
            return View();
        }

        public void RedirectToLogin()
        {
            Redirect("/Login");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public RegistroController(UsuarioService usuarioService, ILogger<RegistroController> logger, HttpClient httpClient)
        {
            _usuarioService = usuarioService;
            _logger = logger;
        }

    }
}
