using Cine.Entidades;
using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.VIewModels;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CiudadController : ControllerBase
{
    private readonly PresentacionDbContext context;

    public CiudadController(PresentacionDbContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var ciudad = context.Ciudades.ToList();
        return Ok(ciudad);
    }

    [HttpPost]
    public ActionResult Post(CiudadViewModel ciudad)
    {
        var nuevaCiudad = new Ciudad(ciudad.NroSede);
        context.Ciudades.Add(nuevaCiudad);
        context.SaveChanges();
        return StatusCode(201, nuevaCiudad);
    }

    [HttpPut]
    public ActionResult Put([FromBody] CiudadViewModel ciudad, Guid id)
    {
        var ciudadConCambios = context.Ciudades.FirstOrDefault(x => x.Id == id);

        ciudadConCambios.Actualizar(ciudad.NroSede);

        context.SaveChanges();

        return Ok(ciudadConCambios);
    }

    [HttpDelete]
    public ActionResult Delete(Guid id)
    {
        var ciudadBorrar = context.Ciudades.FirstOrDefault(x => x.Id == id);

        context.Ciudades.Remove(ciudadBorrar);

        context.SaveChanges();

        return NoContent();
    }
}

