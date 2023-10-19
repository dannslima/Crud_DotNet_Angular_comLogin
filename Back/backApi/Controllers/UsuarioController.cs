using backApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace backApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        [HttpGet(Name = "GetUsuarios")]
        public IActionResult Get()
        {
            UsuarioModel usuario = new UsuarioModel();
            usuario.Nome = "João";

            return Ok(new { usuario });
        }
    }
}
