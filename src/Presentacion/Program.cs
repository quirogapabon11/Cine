using Microsoft.EntityFrameworkCore;
using Presentacion.Persistencia;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("Cine");

builder.Services.AddDbContext<PresentacionDbContext>(opcion =>
    opcion.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 30))));

builder.Services.AddDbContext<PresentacionDbContext>();

var opciones = new DbContextOptionsBuilder<PresentacionDbContext>();

opciones.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 30)));

var contexto = new PresentacionDbContext(opciones.Options);

contexto.Database.EnsureCreated();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

//agrego la configuracion al nuestro contexto AplicacionDbContexto
builder.Services.AddDbContext<PresentacionDbContext>(opcion =>
    opcion.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 30))));

//agrego nuestro context AplicacionDbContext al contenedor de objetos
//con esto el objeto va a ser poder accedido desde cualquier otro objeto
//particularmente los controladores
builder.Services.AddDbContext<PresentacionDbContext>();

