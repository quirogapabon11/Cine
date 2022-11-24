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
public class InvitadoController : ControllerBase
{
    private readonly PresentacionDbContext context;

    public InvitadoController(PresentacionDbContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var invitados = context.Invitados.ToList();
        return Ok(invitados);
    }

    [HttpPost]
    public ActionResult Post(InvitadoViewModel invitado)
    {
        var nuevoInvitado = new Invitado(invitado.Edad);
        context.Invitados.Add(nuevoInvitado);
        context.SaveChanges();
        return StatusCode(201, nuevoInvitado);
    }
}
