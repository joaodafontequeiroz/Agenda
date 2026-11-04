namespace WebApi.Controller.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Aplicacao.Tarefas.AdicionarTarefa.Query;
using Aplicacao.Tarefas.DeletarTarefas.Query;
using Aplicacao.Tarefas.AtualizarTarefa.Query;

public static class Command
{
    public static void CommandRotas (this WebApplication app)
    {
        var Rota =  app.MapGroup("Controller/Command");

         //mandando para o banco os dados relacionados a uma task
        Rota.MapPost("/", async ([FromBody] AdicionarTarefaCommand command,[FromServices]IMediator M)
        =>
        {
            try
            {
                await M.Send(command);
                return Results.Ok();    
            }
            catch
            {
                return Results.BadRequest(new {mensagem = "Formato da hora errado(Ex: 10:00)"});
            }
            
        }).WithTags("Command Routes");

        Rota.MapDelete("/{id:Guid}", async (Guid Id, [FromServices]IMediator M) =>
        {
            return await M.Send(new DeletarTarefaCommand(){Id = Id});
        }).WithTags("Command Routes");


       Rota.MapPatch("/{id:guid}", async (Guid id, [FromServices]IMediator M, [FromBody]AtualizarTarefaCommand command) =>
        {
            return await M.Send(command);
        }).WithTags("Command Routes");
        
        
    }
}
