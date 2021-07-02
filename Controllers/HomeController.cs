using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using App588.Models;

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace App588.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet ("Denegado")]
        public IActionResult Denegado()
        {
            return View();
        }

        public IActionResult Home()
        {
            return View();
        }

        [Authorize]
        public IActionResult Welcome()
        {
            return View();
        }

        [Authorize (Roles ="Administrador")]
        public IActionResult Privado()
        {
            return View();
        }

        public IActionResult Nosotros()
        {
            return View();
        }

        //-----------------------------------AUTENTICACION-----------------------------------------------
        [HttpGet("Login")]
        public IActionResult Login(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost("Login")]

        public async Task<IActionResult> validar(string username, string password, string returnUrl)
        {
            // lectura de la base de datos

            var db =  new netsenaContext();
            var usuariologueado = db.Usuarios.FirstOrDefault(u =>u.Usuario == username && u.Contraseña == password);

            if (usuariologueado != null)
            {
                var claims = new List<Claim>();
                claims.Add(new Claim("username", usuariologueado.Usuario));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, username));
                claims.Add(new Claim(ClaimTypes.Name, usuariologueado.Nombre));
                claims.Add(new Claim(ClaimTypes.Role, usuariologueado.Rol));
                var claimsidentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsprincipal = new ClaimsPrincipal(claimsidentity);
                await HttpContext.SignInAsync(claimsprincipal);
                return Redirect(returnUrl);
            }
            else
            {
                ViewData["ReturnUrl"] = returnUrl;
                TempData["Error"] = "El usuario o contraseña no son validos ";
                return View("Login");

            }
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }

        //-----------------------------------------------------------------------------------------------
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
