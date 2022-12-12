using Cine.Entidades;
using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.VIewModels;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CadenaCineController : ControllerBase
{
    private readonly PresentacionDbContext context;

    public CadenaCineController(PresentacionDbContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var cadenacines = context.CadenadeCines.ToList();
        return Ok(cadenacines);
    }

    [HttpPost]
    public ActionResult Post(CadenaCineViewModel cadenaCine)
    {
        var nuevaCadenaCine = new CadenaCine(cadenaCine.Nombre);
        context.CadenadeCines.Add(nuevaCadenaCine);
        context.SaveChanges();
        return StatusCode(201, nuevaCadenaCine);
    }

    [HttpPut]
    public ActionResult Put([FromBody] CadenaCineViewModel cadenaCine, Guid id)
    {
        var cadenaCineConCambios = context.CadenadeCines.FirstOrDefault(x => x.Id == id);

        cadenaCineConCambios!.Actualizar(cadenaCine.Nombre);

        context.SaveChanges();

        return Ok(cadenaCineConCambios);
    }

    [HttpDelete]
    public ActionResult Delete(Guid id)
    {
        var cadenaCineBorrar = context.CadenadeCines.FirstOrDefault(x => x.Id == id);

        context.CadenadeCines.Remove(cadenaCineBorrar!);

        context.SaveChanges();

        return NoContent();
    }
}

