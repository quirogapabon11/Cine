using Cine.Entidades;
using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.ViewModels;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MiembroController : ControllerBase
{
    private readonly PresentacionDbContext context;

    public MiembroController(PresentacionDbContext context)
    {
        this.context = context;

    }

    [HttpGet]
    public ActionResult Get()
    {
        var miembros = context.Miembros.ToList();
        return Ok(miembros);
    }

    [HttpPost]
    public ActionResult Post(MiembroViewModel miembro)
    {
        var nuevoMiembro = new Miembro(false);
        context.Miembros.Add(nuevoMiembro);
        context.SaveChanges();
        return StatusCode(201, nuevoMiembro);
    }
    [HttpPut]
    public ActionResult Put([FromBody] MiembroViewModel miembro, Guid id)
    {
        var miembroConCambios = context.Miembros.FirstOrDefault(x => x.Id == id);

        miembroConCambios.Actualizar(miembro.Habilitado);

        context.SaveChanges();

        return Ok(miembroConCambios);
    }

    [HttpDelete]
    public ActionResult Delete(Guid id)
    {
        var miembroBorrar = context.Miembros.FirstOrDefault(x => x.Id == id);

        context.Miembros.Remove(miembroBorrar);

        context.SaveChanges();

        return NoContent();
    }

}
