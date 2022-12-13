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
        var nuevaProyeccion = new Proyeccion(proyeccion.Pelicula, proyeccion.idSala, proyeccion.idCine, proyeccion.Formato, proyeccion.Horario);
        context.Proyecciones.Add(nuevaProyeccion);
        context.SaveChanges();
        return StatusCode(201, nuevaProyeccion);
    }

    [HttpPut]
    public ActionResult Put([FromBody] ProyeccionViewModel proyeccion, Guid id)
    {
        var proyeccionConCambios = context.Proyecciones.FirstOrDefault(x => x.Id == id);

        proyeccionConCambios.Actualizar(proyeccion.Pelicula, proyeccion.idSala, proyeccion.idCine, proyeccion.Formato, proyeccion.Horario);

        context.SaveChanges();

        return Ok(proyeccionConCambios);
    }

    [HttpDelete]
    public ActionResult Delete(Guid id)
    {
        var proyeccionBorrar = context.Proyecciones.FirstOrDefault(x => x.Id == id);

        context.Proyecciones.Remove(proyeccionBorrar);

        context.SaveChanges();

        return NoContent();
    }
}

