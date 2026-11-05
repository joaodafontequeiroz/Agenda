namespace WebApi.Controller.Command;

using WebApi.RetornoPadrao;
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
        Rota.MapPost("/", async (AdicionarTarefaCommand command,[FromServices]IMediator M)
        =>
        {
            try
            {
                await M.Send(command);
                RetornoPadrao<string> mensagem = new();
                mensagem.DeuCerto = true;
                mensagem.Mensagem = "Tarefa adicionada com sucesso";
                return Results.Ok(mensagem);    
            }
            catch
            {
                RetornoPadrao<string> mensagem = new();
                mensagem.DeuCerto = false;
                mensagem.Mensagem ="Tarefa nao adicionada, Formato da hora errado(Ex: 10:00)";
                return Results.BadRequest(mensagem);
            }
            
        }).WithTags("Command Routes");

        Rota.MapDelete("/{id:Guid}", async (Guid Id, [FromServices]IMediator M) =>
        {
            try
            {
                await M.Send(new DeletarTarefaCommand(){Id = Id});
                RetornoPadrao<Guid> mensagem = new();
                mensagem.Data = Id;
                mensagem.DeuCerto = true;
                mensagem.Mensagem = "tarefa deletada com sucesso";
                return Results.Ok(mensagem);     
            }

            catch
            {
                RetornoPadrao<Guid> mensagem = new();
                mensagem.Data = Id;
                mensagem.DeuCerto = false;
                mensagem.Mensagem = "Erro ao deletar tarefa";
                return Results.BadRequest(mensagem);
            }
           
        }).WithTags("Command Routes");


       Rota.MapPatch("/{id:guid}", async (Guid id, [FromServices]IMediator M, [FromBody]AtualizarTarefaCommand command) =>
        {
            try
            {
                await M.Send(command);
                RetornoPadrao<Guid> mensagem = new();
                mensagem.Data = id;
                mensagem.DeuCerto = true;
                mensagem.Mensagem = "tarefas atualizadas com sucesso";
                return Results.Ok(mensagem);     
            }

            catch
            {
                RetornoPadrao<Guid> mensagem = new();
                mensagem.Data = id;
                mensagem.DeuCerto = false;
                mensagem.Mensagem = "Erro ao atualizar tarefas";
                return Results.BadRequest(mensagem);
            }
        }).WithTags("Command Routes");
        
        
    }
}
