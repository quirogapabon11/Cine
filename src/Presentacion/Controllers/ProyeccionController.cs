using Cine.Entidades;
using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.VIewModels;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProyeccionController : ControllerBase
{
    private readonly PresentacionDbContext context;

    public ProyeccionController(PresentacionDbContext context)
    {
        this.context = context;
    }
    [HttpGet]
    public ActionResult Get()
    {
        var proyecciones = context.Proyecciones.ToList();
        return Ok(proyecciones);
    }

    [HttpPost]
    public ActionResult Post(ProyeccionViewModel proyeccion)
    {
        var nuevaProyeccion = new Proyeccion(proyeccion.Pelicula, proyeccion.Sala, proyeccion.Cine, proyeccion.Formato, proyeccion.Horario);
        context.Proyecciones.Add(nuevaProyeccion);
        context.SaveChanges();
        return StatusCode(201, nuevaProyeccion);
    }
}

