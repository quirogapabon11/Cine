using Cine.Entidades;
using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.VIewModels;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CuponController : ControllerBase
{
    private readonly PresentacionDbContext context;

    public CuponController(PresentacionDbContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var cupones = context.Cupones.ToList();
        return Ok(cupones);
    }

    [HttpPost]
    public ActionResult Post(CuponViewModel cupon)
    {
        var nuevoCupon = new Cupon(cupon.Descuento, cupon.Codigo);
        context.Cupones.Add(nuevoCupon);
        context.SaveChanges();
        return StatusCode(201, nuevoCupon);
    }

    [HttpPut]
    public ActionResult Put([FromBody] CuponViewModel cupon, Guid id)
    {
        var cuponConCambios = context.Cupones.FirstOrDefault(x => x.Id == id);

        cuponConCambios.Actualizar(cupon.Descuento, cupon.Codigo);

        context.SaveChanges();

        return Ok(cuponConCambios);
    }

    [HttpDelete]
    public ActionResult Delete(Guid id)
    {
        var cuponBorrar = context.Cupones.FirstOrDefault(x => x.Id == id);

        context.Cupones.Remove(cuponBorrar);

        context.SaveChanges();

        return NoContent();
    }
}

