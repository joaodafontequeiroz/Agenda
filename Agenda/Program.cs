using Routes.TaskRoute;
using Scalar;
using Scalar.AspNetCore;
using Data.ContextTask;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddDbContext<TaskContext>(options => options.UseSqlite("Data Source=agenda.db"));
builder.Services.AddCors(options =>
    {
        options.AddPolicy("agendaApi",
            builder => builder
            .WithOrigins("http://localhost:5173")
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials());
    });
var app = builder.Build();

app.UseCors("agendaApi");

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();
app.MapControllers();
app.TasKRoutes();
app.Run();
