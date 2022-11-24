using Cine.Entidades;
using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.VIewModels;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SalaController : ControllerBase
{
    private readonly PresentacionDbContext context;

    public SalaController(PresentacionDbContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var salas = context.Salas.ToList();
        return Ok(salas);
    }

    [HttpPost]
    public ActionResult Post(SalaViewModel sala)
    {
        var sede = context.Sedes.FirstOrDefault(x => x.Id == sala.IdSede);
        var nuevaSala = new Sala(sala.Asientos);
        context.Salas.Add(nuevaSala);
        context.SaveChanges();
        return StatusCode(201, nuevaSala);
    }
}
