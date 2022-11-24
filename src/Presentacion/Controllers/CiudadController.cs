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
}
