using Scalar.AspNetCore;
using Infra.Data.ContextTask ;
using Microsoft.EntityFrameworkCore;
using WebApi.Controller.Command;
using WebApi.Controller.Query;
using Infra.Repository.RepositorioTarefas;
using Dominio.Interfaces.Interface;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddScoped<ITarefasRepositorio, RepositorioTarefas>();
builder.Services.AddDbContext<TaskContext>(options => options.UseSqlite("Data Source=agenda.db"));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));
foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies()) { builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(assembly)); }
builder.Services.AddCors(options =>
    {
        options.AddPolicy("agendaApi",
            builder => builder
            .WithOrigins("http://localhost:5173")
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials());
    });
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

var app = builder.Build();

app.UseCors("agendaApi");

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();
app.MapControllers();
app.CommandRotas();
app.QueriesRotas();
app.Run();
