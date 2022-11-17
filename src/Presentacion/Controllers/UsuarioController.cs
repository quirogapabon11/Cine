using Cine.Entidades;
using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.VIewModels;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly PresentacionDbContext context;

    public UsuarioController(PresentacionDbContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var usuarios = context.Usuarios.ToList();
        return Ok(usuarios);
    }

    [HttpPost]
    public ActionResult Post(UsuarioViewModel usuario)
    {
        var nuevoUsuario = new Usuario(usuario.Nombre, usuario.Apellido, usuario.Email, usuario.Contrasena);
        context.Usuarios.Add(nuevoUsuario);
        context.SaveChanges();
        return StatusCode(201, nuevoUsuario);
    }

}