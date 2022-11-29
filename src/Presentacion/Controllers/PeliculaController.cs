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

    [HttpPut]
    public ActionResult Put([FromBody] PeliculaViewModel pelicula, Guid id)
    {
        var peliculaConCambios = context.Peliculas.FirstOrDefault(x => x.Id == id);

        peliculaConCambios.Actualizar(pelicula.Titulo, pelicula.Descripcion, pelicula.Idioma, pelicula.Genero, pelicula.Lanzamiento, pelicula.Calidad, pelicula.Duracion);

        context.SaveChanges();

        return Ok(peliculaConCambios);
    }

    [HttpDelete]
    public ActionResult Delete(Guid id)
    {
        var peliculaBorrar = context.Peliculas.FirstOrDefault(x => x.Id == id);

        context.Peliculas.Remove(peliculaBorrar);

        context.SaveChanges();

        return NoContent();
    }
}
