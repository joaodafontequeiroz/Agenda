namespace Routes.TaskRoute;
using Esqueci.TaskRequest;
using Data.ContextTask;
using Modules.Task;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

public static class TaskRoute
{
    public static void TasKRoutes (this WebApplication app)
    {
        var group = app.MapGroup("Routes/TaskRoutes");
    
        group.MapPost("/", async (TaskContext context, TaskRequest req)
        =>
        {
            
            Task t = new Task(req.Hora, req.Classe, req.Titulo, req.Corpo, req.Concluido);
            await context.Tasks.AddAsync(t);
            await context.SaveChangesAsync();

        });

        group.MapGet("/{Id}", async (Guid id ,TaskContext context) =>
        {
            Task t = await context.Tasks.FirstOrDefaultAsync(x => x.Id == id);

            if (t == null) return Results.NotFound(new{ mensagem = "Task nao encontrada no banco"});

            return Results.Ok(t);
        });
    }
}