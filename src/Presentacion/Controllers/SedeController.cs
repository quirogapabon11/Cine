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
        var nuevaSede = new Sede(sede.Nombre, sede.Direccion, sede.Ciudad, sede.Proyeccion);
        context.Sedes.Add(nuevaSede);
        context.SaveChanges();
        return StatusCode(201, nuevaSede);
    }
}
