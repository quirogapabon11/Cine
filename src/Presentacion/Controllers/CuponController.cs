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
        var nuevoCupon = new Cupon(cupon.Descuento);
        context.Cupones.Add(nuevoCupon);
        context.SaveChanges();
        return StatusCode(201, nuevoCupon);
    }
}
