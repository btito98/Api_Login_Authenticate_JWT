using ApiAuth.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ApiAuth.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => String.Format($"Autenticado - {User.Identity.Name}");

        [HttpGet]
        [Route("operador")]
        [Authorize(Roles = "operador, administrador")]
        public string Operador() => "Operador";

        [HttpGet]
        [Route("administrador")]
        [Authorize(Roles = "administrador")]
        public string Administrador() => "Administrador";
    }
}