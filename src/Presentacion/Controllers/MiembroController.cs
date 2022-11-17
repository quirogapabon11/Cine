
using Cine.Entidades;
using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;

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
        var nuevoMiembro = new Miembro();
        context.Miembros.Add(nuevoMiembro);
        context.SaveChanges();
        return StatusCode(201, nuevoMiembro);
    }
}
