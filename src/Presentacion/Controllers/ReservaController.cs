using Cine.Entidades;
using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.VIewModels;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReservaController : ControllerBase
{
    private readonly PresentacionDbContext context;

    public ReservaController(PresentacionDbContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var reservas = context.Reservas.ToList();
        return Ok(reservas);
    }

    [HttpPost]
    public ActionResult Post(ReservaViewModel reserva)
    {
        var proyeccion = context.Proyecciones.FirstOrDefault(x => x.Id == reserva.IdProyeccion);
        var nuevaReserva = new Reserva(reserva.Nro, reserva.NroAsiento, reserva.Estado, reserva.NroSala, reserva.NombreSede, proyeccion);
        context.Reservas.Add(nuevaReserva);
        context.SaveChanges();
        return StatusCode(201, nuevaReserva);
    }
}
