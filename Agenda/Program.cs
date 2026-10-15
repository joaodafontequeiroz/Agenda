using Routes.TaskRoute;
using Scalar;
using Scalar.AspNetCore;
using Data.ContextTask;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddDbContext<TaskContext>(options => options.UseSqlite("Data Source=agenda.db"));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();
app.MapControllers();
app.TasKRoutes();
app.Run();
