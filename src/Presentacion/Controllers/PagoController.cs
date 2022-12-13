using Cine.Entidades;
using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.VIewModels;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PagoController : ControllerBase
{
    private readonly PresentacionDbContext context;

    public PagoController(PresentacionDbContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var pagos = context.Pagos.ToList();
        return Ok(pagos);
    }

    [HttpPost]
    public ActionResult Post(PagoViewModel pago)
    {
        var nuevoPago = new Pago(pago.tipoPago, pago.Monto);
        context.Pagos.Add(nuevoPago);
        context.SaveChanges();
        return StatusCode(201, nuevoPago);
    }

    [HttpPost("/api/Pago/{idPago}/Notificacion/{idNotificacion}")]
    public ActionResult AsignarMiembro(Guid idPago, Guid idNotificacion)
    {
        var pagoConCambios = context.Pagos.FirstOrDefault(x => x.Id == idPago);

        var notificacion = context.Notificaciones.FirstOrDefault(x => x.Id == idNotificacion);

        pagoConCambios!.Notificaciones.Add(notificacion!);

        context.SaveChanges();

        return Ok(pagoConCambios);
    }

    [HttpPost("/api/Pago/{idPago}/Cupon/{idCupon}")]
    public ActionResult AsignarCupon(Guid idPago, Guid idCupon)
    {
        var pagoConCambios = context.Pagos.FirstOrDefault(x => x.Id == idPago);

        var cupon = context.Cupones.FirstOrDefault(x => x.Id == idCupon);

        pagoConCambios!.Cupones.Add(cupon!);

        context.SaveChanges();

        return Ok(pagoConCambios);
    }


    [HttpPut]
    public ActionResult Put([FromBody] PagoViewModel pago, Guid id)
    {
        var pagoConCambios = context.Pagos.FirstOrDefault(x => x.Id == id);

        pagoConCambios!.Actualizar(pago.Monto);

        context.SaveChanges();

        return Ok(pagoConCambios);
    }

    [HttpDelete]
    public ActionResult Delete(Guid id)
    {
        var pagoBorrar = context.Pagos.FirstOrDefault(x => x.Id == id);

        context.Pagos.Remove(pagoBorrar!);

        context.SaveChanges();

        return NoContent();
    }

}
