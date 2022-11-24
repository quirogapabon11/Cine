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
}
