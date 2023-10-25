using backApi.Models;
using Microsoft.EntityFrameworkCore;
using backApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<UsuarioModel, UsuarioModel>();
builder.Services.AddScoped<UsuarioService, UsuarioService>();


builder.Services.AddScoped<DataContext, DataContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//trecho abaixo do cors autoriza qualquer origem, qualquer metodo e qualquer header sem ele o angular nao consegue chamar os metodos da api
app.UseCors(x => x
    .AllowAnyOrigin()
       .AllowAnyMethod()
          .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
