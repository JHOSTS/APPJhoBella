using AppJhoBella.ApiUsuario.Data.Dto;
using AppJhoBella.ApiUsuario.Services;
using Microsoft.AspNetCore.Mvc;

namespace AppJhoBella.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private UsuarioService _usuarioService;


        public async Task<IActionResult> Login(LoginUsuarioDto dto)
        {
            if (!ModelState.IsValid) return ViewLogin();


            await _usuarioService.Login(dto);
            return Redirect("/Home/Lembretes");
        }

        public IActionResult ViewLogin()
        {
            return View();
        }
        public LoginController(UsuarioService usuarioService, ILogger<HomeController> logger)
        {
            _usuarioService = usuarioService;
            _logger = logger;
        }
    }
}
