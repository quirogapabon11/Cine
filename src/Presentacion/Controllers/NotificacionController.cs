using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cine.Entidades;
using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.VIewModels;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NotificacionController : ControllerBase
{
    private readonly PresentacionDbContext context;

    public NotificacionController(PresentacionDbContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var notificaciones = context.Notificaciones.ToList();
        return Ok(notificaciones);
    }

    [HttpPost]
    public ActionResult Post(NotificacionViewModel notificacion)
    {
        var nuevaNotificacion = new Notificacion(notificacion.Email);
        context.Notificaciones.Add(nuevaNotificacion);
        context.SaveChanges();
        return StatusCode(201, nuevaNotificacion);
    }

    [HttpPut]
    public ActionResult Put([FromBody] NotificacionViewModel notificacion, Guid id)
    {
        var notificacionConCambios = context.Notificaciones.FirstOrDefault(x => x.Id == id);

        notificacionConCambios.Actualizar(notificacion.Email);

        context.SaveChanges();

        return Ok(notificacionConCambios);
    }

    [HttpDelete]
    public ActionResult Delete(Guid id)
    {
        var notificacionBorrar = context.Notificaciones.FirstOrDefault(x => x.Id == id);

        context.Notificaciones.Remove(notificacionBorrar);

        context.SaveChanges();

        return NoContent();
    }
}
