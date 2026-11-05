namespace WebApi.Controller.Query;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using WebApi.RetornoPadrao;
using Aplicacao.Tarefas.ListarTarefas.Query;
using Aplicacao.Tarefas.ContarTarefasConcluidas.Query;
using Aplicacao.Tarefas.ContarTarefasPendentes.Query;
using Aplicacao.Tarefas.PorcentagemConcluidaRelacionadoAoTotal.Query;
using Aplicacao.DatasCalendario.ObterDataEmNumero.Query;
using Aplicacao.DatasCalendario.ObterDataExtenso.ObterDataExtenso.Query;
using Aplicacao.DatasCalendario.ObterDataMesAnoExtenso.Query;
using Aplicacao.DatasCalendario.Ehoje.Query;
using Aplicacao.Tarefas.ContarTarefas.Query;
using Dominio.Entidades.Tarefa;

public static class Queries
{
    public static void QueriesRotas (this WebApplication app)
    {
        var Rota = app.MapGroup("Controller/Queries");

       //Dia em numero
        Rota.MapGet("/diaNumero" ,async ([FromServices]IMediator M) =>
        { 
            try
            {
                RetornoPadrao<int> mensagem = new();
                mensagem.Data = await M.Send(new ObterDataEmNumeroQuery());
                mensagem.DeuCerto = true;
                mensagem.Mensagem = "Data em formato de numero resgatada com sucesso";
                return Results.Ok(mensagem);
            }
            catch
            {
                RetornoPadrao<int> mensagem = new();
                mensagem.DeuCerto = false;
                mensagem.Mensagem = "Erro ao resgatar data em formato de numero";
                return Results.BadRequest(mensagem);
            }
        }).WithTags("Querie route");
        
        //Dia por extenso
        Rota.MapGet("/diaExtenso" ,async ([FromServices]IMediator M) =>
        {
            try
            {
                RetornoPadrao<string> mensagem = new();
                mensagem.Data = await M.Send(new ObterDataExtensoQuery()); 
                mensagem.DeuCerto = true;
                mensagem.Mensagem = "dia em formato de texto resgatada com sucesso";
                return Results.Ok(mensagem);
            }
            catch
            {
                RetornoPadrao<string> mensagem = new();
                mensagem.DeuCerto = false;
                mensagem.Mensagem = "Erro ao resgatar dia em formato de texto";
                return Results.Ok(mensagem);
            }
        }).WithTags("Querie route");
        
        //mes e ano 
        Rota.MapGet("/mesEano" ,async ([FromServices]IMediator M) =>
        {
            try
            {
                
                RetornoPadrao<string> mensagem = new();
                mensagem.Data = await M.Send(new ObterDataMeseAnoExtensoQuery()); 
                mensagem.DeuCerto = true;
                mensagem.Mensagem = "Data em formato de mes e ano resgatada com sucesso";
                return Results.Ok(mensagem);
            }
            catch
            {
                RetornoPadrao<string> mensagem = new();
                mensagem.DeuCerto = false;
                mensagem.Mensagem = "Erro ao resgatar data em formato de mes e ano";
                return Results.BadRequest(mensagem);
            }    
        }).WithTags("Querie route");
        
        //verificacao se e hoje
        Rota.MapGet("/Ehoje" ,async ([FromServices]IMediator M) =>
        {
               try
            {
                RetornoPadrao<bool> mensagem = new();
                mensagem.Data = await M.Send(new EhojeQuery());
                mensagem.DeuCerto = true;
                mensagem.Mensagem = "verificacao se a data atual corresponde com hoje efetivada";
                return Results.Ok(mensagem);
            }
            catch
            {
                RetornoPadrao<bool> mensagem = new();
                mensagem.DeuCerto = false;
                mensagem.Mensagem = "Erro ao verificacao se a data atual corresponde com hoje";
                return Results.BadRequest(mensagem);
            }
        }).WithTags("Querie route");

        //pegando contando todas as tasks
        Rota.MapGet("/todas", async ([FromServices]IMediator M) =>
        {
            
            try
            {
                RetornoPadrao<int> mensagem = new();
                mensagem.Data = await M.Send(new ContarTarefasQuery()); 
                mensagem.DeuCerto = true;
                mensagem.Mensagem = "todas as tarefas foram contadas com sucesso";
                return Results.Ok(mensagem);
            }
            catch
            {
                RetornoPadrao<int> mensagem = new();
                mensagem.DeuCerto = false;
                mensagem.Mensagem = "Erro ao contar todas as tarefas";
                return Results.BadRequest(mensagem);
            }
        }).WithTags("Querie route");

        //listando todas as tasks
        Rota.MapGet("/listar", async ([FromServices] IMediator M) =>
        {
            
            try
            {
                RetornoPadrao<List<Tarefa>> mensagem = new();
                mensagem.Data = await M.Send(new ListarTarefasQuery()); 
                mensagem.DeuCerto = true;
                mensagem.Mensagem = "todas as tarefas foram listadas com sucesso";
                return Results.Ok(mensagem);
            }
            catch
            {
                RetornoPadrao<List<Tarefa>> mensagem = new();
                mensagem.DeuCerto = false;
                mensagem.Mensagem = "Erro ao listar todas as tarefas";
                return Results.BadRequest(mensagem);
            }
            
        }).WithTags("Querie route");

        //retorna a quantidade de tasks concluidas
        Rota.MapGet("/concluidas", async ([FromServices]IMediator M) =>
        {
            try
            {
                RetornoPadrao<int> mensagem = new();
                mensagem.Data = await M.Send(new ContarTarefasConcluidasQuery());
                mensagem.DeuCerto = true;
                mensagem.Mensagem = "contagem da quantidade de tarefas concluidas concluido";
                return Results.Ok(mensagem);
            }
            catch
            {
                RetornoPadrao<int> mensagem = new();
                mensagem.DeuCerto = false;
                mensagem.Mensagem = "erro ao contar quantidade de tarefas concluidas";
                return Results.BadRequest(mensagem);
            }
        }).WithTags("Querie route");

        //retorna a quantidade de tasks pendentes
        Rota.MapGet("/pendentes" ,async ([FromServices]IMediator M) =>
        {
             try
            {
                RetornoPadrao<int> mensagem = new();
                mensagem.Data = await M.Send(new ContarTarefasPendentesQuery());
                mensagem.DeuCerto = true;
                mensagem.Mensagem = "contagem da quantidade de tarefas pendentes concluido";
                return Results.Ok(mensagem);
            }
            catch
            {
                RetornoPadrao<int> mensagem = new();
                mensagem.DeuCerto = false;
                mensagem.Mensagem = "erro ao contar quantidade de tarefas pendentes";
                return Results.BadRequest(mensagem);
            }
        }).WithTags("Querie route");
        //retorna a porcentagem de concluidas em relacao ao total de tasks
        Rota.MapGet ("/porcent" , async([FromServices]IMediator M) =>
        {
             try
            {
                RetornoPadrao<int> mensagem = new();
                mensagem.Data = await M.Send(new PorcentagemConcluidaRelacionadoAoTotalQuery());
                mensagem.DeuCerto = true;
                mensagem.Mensagem = "porcentagem das tasks restantes calculadas e enviadas com sucesso";
                return Results.Ok(mensagem);
            }
            catch
            {
                RetornoPadrao<int> mensagem = new();
                mensagem.DeuCerto = false;
                mensagem.Mensagem = "erro ao calcular a porcentagem das tasks restantes";
                return Results.BadRequest(mensagem);
            }
        }).WithTags("Querie route");

    }
}