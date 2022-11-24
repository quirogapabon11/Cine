using Cine.Entidades;
using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.VIewModels;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PeliculaController : ControllerBase
{
    private readonly PresentacionDbContext context;

    public PeliculaController(PresentacionDbContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var peliculas = context.Peliculas.ToList();
        return Ok(peliculas);
    }

    [HttpPost]
    public ActionResult Post(PeliculaViewModel pelicula)
    {
        var nuevaPelicula = new Pelicula(pelicula.Titulo, pelicula.Descripcion, pelicula.Idioma, pelicula.Genero, pelicula.Lanzamiento, pelicula.Calidad, pelicula.Duracion);
        context.Peliculas.Add(nuevaPelicula);
        context.SaveChanges();
        return StatusCode(201, nuevaPelicula);
    }
}
