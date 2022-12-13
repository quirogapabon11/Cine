using Cine.Entidades;
using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.VIewModels;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SedeController : ControllerBase
{
    private readonly PresentacionDbContext context;

    public SedeController(PresentacionDbContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var sedes = context.Sedes.ToList();
        return Ok(sedes);
    }

    [HttpPost]
    public ActionResult Post(SedeViewModel sede)
    {
        var nuevaSede = new Sede(sede.Nombre, sede.Direccion, sede.Ciudad);
        context.Sedes.Add(nuevaSede);
        context.SaveChanges();
        return StatusCode(201, nuevaSede);
    }

    [HttpPost("/api/Sede/{idSede}/Sala/{idSala}")]
    public ActionResult AsignarSede(Guid idSede, Guid idSala)
    {
        var sedeConCambios = context.Sedes.FirstOrDefault(x => x.Id == idSede);

        var sala = context.Salas.FirstOrDefault(x => x.Id == idSala);

        sedeConCambios.Salas.Add(sala!);

        context.SaveChanges();

        return Ok(sedeConCambios);
    }


    [HttpPut]
    public ActionResult Put([FromBody] SedeViewModel sede, Guid id)
    {
        var sedeConCambios = context.Sedes.FirstOrDefault(x => x.Id == id);

        sedeConCambios.Actualizar(sede.Ciudad, sede.Direccion, sede.Nombre);

        context.SaveChanges();

        return Ok(sedeConCambios);
    }

    [HttpDelete]
    public ActionResult Delete(Guid id)
    {
        var sedeBorrar = context.Sedes.FirstOrDefault(x => x.Id == id);

        context.Sedes.Remove(sedeBorrar);

        context.SaveChanges();

        return NoContent();
    }
}
