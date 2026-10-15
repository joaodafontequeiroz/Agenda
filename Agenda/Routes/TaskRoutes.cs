using Humanizer;
namespace Routes.TaskRoute;
using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Esqueci.TaskRequest;
using Data.ContextTask;
using Modules.Task;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

public static class TaskRoute
{
    public static void TasKRoutes (this WebApplication app)
    {
        var group = app.MapGroup("Routes/TaskRoutes");

        //mandando para o banco os dados relacionados a uma task
        group.MapPost("/", async ([FromServices] TaskContext context, [FromBody]TaskRequest req)
        =>
        {
            
            Task t = new Task(req.Hora, req.Classe, req.Titulo, req.Corpo, req.Concluido);
            await context.Tasks.AddAsync(t);
            await context.SaveChangesAsync();

        }).WithTags("Task Routes");

        //pegando e listando todas as tasks
        group.MapGet("/todas", async ([FromServices] TaskContext context) =>
        {
            return Results.Ok(await context.Tasks.ToListAsync());
        }).WithTags("Task Routes");
        //deletando uma task por ID (acao quando clicam no xzinho no front)
        group.MapDelete("/{id}", async (Guid Id, [FromServices] TaskContext context) =>
        {
            var id = await context.Tasks.Where(t => t.Id == Id).ExecuteDeleteAsync();
        }).WithTags("Task Routes");
        
        //retorna a quantidade de tasks concluidas
        group.MapGet("/concluidas", async ([FromServices] TaskContext context) =>
        {
            int QtdConcluidas = 0;
            QtdConcluidas = await context.Tasks.CountAsync(t => t.Concluido == true);
            return Results.Ok(QtdConcluidas);
        }).WithTags("Task Routes");

        //retorna a quantidade de tasks pendentes
        group.MapGet("/pendentes" ,async ([FromServices] TaskContext context) =>
        {
            int QtdPendentes = await context.Tasks.CountAsync(t => t.Concluido == false);
            return Results.Ok(QtdPendentes);
        }).WithTags("Task Routes");
        //retorna a porcentagem de concluidas em relacao ao total de tasks
        group.MapGet ("/porcent" , async([FromServices]TaskContext context) =>
        {
            int total = await context.Tasks.CountAsync();
            int QtdConcluidas = await context.Tasks.CountAsync(t => t.Concluido == true);
            double porcentagem = ((100) * (QtdConcluidas)) / (total);
            return Results.Ok(porcentagem);
        }).WithTags("Task Routes");

        //Dia em numero
        group.MapGet("/diaNumero" ,() =>
        {
            int d = DateTime.Now.Day;
            return Results.Ok(d);
        }).WithTags("Date Routes");
        //Dia por extenso
        group.MapGet("/diaExtenso" ,() =>
        {
            String d = DateTime.Now.ToString("dddd", new CultureInfo("pt-Br"));
            return Results.Ok(d);
        }).WithTags("Date Routes");
        //mes e ano 
        group.MapGet("/mesEano" ,() =>
        {
            String d = DateTime.Now.ToString("dd 'de' MMMM yyyy", new CultureInfo("pt-Br"));
            return Results.Ok(d);
        }).WithTags("Date Routes");
        //verificacao se e hoje
        group.MapGet("/Ehoje" ,() =>
        {
            bool isT = true;

            return Results.Ok(isT);
        }).WithTags("Date Routes");
    }
}