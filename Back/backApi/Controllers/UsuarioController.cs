using backApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : Controller
{
    [HttpGet]
    [Route("ListarUsuarios")]
    public IActionResult Get()
    {
        UsuarioModel usuario = new UsuarioModel();
        List<UsuarioModel> listaUsuarios = usuario.ListarUsuarios();

        return Ok(new { listaUsuarios });
    }


    [HttpPost]
    [Route("CriarUsuario")]
    [Authorize]
    public IActionResult Post(UsuarioModel usuario)
    {
        usuario.CriarUsuario(usuario);

        return Ok(new { usuario });
    }

    [HttpPut]
    [Route("AtualizarUsuario")]
    public IActionResult Put(UsuarioModel usuario)
    {
        usuario.AtualizarUsuario(usuario);

        return Ok(new { usuario });
    }

    [HttpDelete]
    [Route("DeletarUsuario/{usuarioId}")]
    public IActionResult Delete(int usuarioId)
    {
        UsuarioModel usuario = new UsuarioModel();
        usuario.Id = usuarioId;
        usuario.DeletarUsuario(usuario.Id);

        return Ok();
    }

    [HttpGet]
    [Route("AutenticarUsuario")]
    public IActionResult Get(string usuarioLogin, string usuarioSenha)
    {
        UsuarioModel usuario = new UsuarioModel();
        if (usuario.AutenticarUsuario(usuarioLogin, usuarioSenha))
            return Ok("Logado com sucesso!");
        else 
            return Unauthorized("Erro de usuario/senha");

    }


}
