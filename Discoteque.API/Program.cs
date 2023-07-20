using Microsoft.EntityFrameworkCore;
using Discoteque.Data;
using Discoteque.Business.IServices;
using Discoteque.Business.Services;
/* referenciar un proyecto dotnet add Discoteque.API/ reference Discoteque.Data/Discoteque.Data.csproj */

/*
una variable con var, es una variable que no se su valor y lo adquiere en tiempo de ejecucion.
al momento de pasarle un valor esta toma el tipo y ya despues no puede asignarle un tipo diferente
*/
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

/* agregando los controladores */
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
/* agregando endpoint */
builder.Services.AddEndpointsApiExplorer();
/* agregando swagger */
builder.Services.AddSwaggerGen();

/* agregando una DB */
builder.Services.AddDbContext<DiscotequeContext>(
  opt => opt.UseInMemoryDatabase("Discoteque")
);

builder.Services.AddScoped<IArtistService, ArtistService>();

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
