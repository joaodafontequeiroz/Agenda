namespace WebApi.Controller.Query;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Aplicacao.Tarefas.ListarTarefas.Query;
using Aplicacao.Tarefas.ContarTarefasConcluidas.Query;
using Aplicacao.Tarefas.ContarTarefasPendentes.Query;
using Aplicacao.Tarefas.PorcentagemConcluidaRelacionadoAoTotal.Query;
using Aplicacao.DatasCalendario.ObterDataEmNumero.Query;
using Aplicacao.DatasCalendario.ObterDataExtenso.ObterDataExtenso.Query;
using Aplicacao.DatasCalendario.ObterDataMesAnoExtenso.Query;
using Aplicacao.DatasCalendario.Ehoje.Query;
using Aplicacao.Tarefas.ContarTarefas.Query;


public static class Queries
{
    public static void QueriesRotas (this WebApplication app)
    {
        var Rota = app.MapGroup("Controller/Queries");

       //Dia em numero
        Rota.MapGet("/diaNumero" ,async ([FromServices]IMediator M) =>
        {
            return await M.Send(new ObterDataEmNumeroQuery());
        }).WithTags("Querie route");
        
        //Dia por extenso
        Rota.MapGet("/diaExtenso" ,async ([FromServices]IMediator M) =>
        {
            return await M.Send(new ObterDataExtensoQuery());
        }).WithTags("Querie route");
        
        //mes e ano 
        Rota.MapGet("/mesEano" ,async ([FromServices]IMediator M) =>
        {
            return await M.Send(new ObterDataMeseAnoExtensoQuery());
        }).WithTags("Querie route");
        
        //verificacao se e hoje
        Rota.MapGet("/Ehoje" ,async ([FromServices]IMediator M) =>
        {
            return await M.Send(new EhojeQuery());
        }).WithTags("Querie route");

        //pegando contando todas as tasks
        Rota.MapGet("/todas", async ([FromServices]IMediator M) =>
        {
            return await M.Send(new ContarTarefasQuery());
        }).WithTags("Querie route");
        //deletando uma task por ID (acao quando clicam no xzinho no front)
        
        //listando todas as tasks
        Rota.MapGet("/listar", async ([FromServices] IMediator M) =>
        {
            return await M.Send(new ListarTarefasQuery());
        }).WithTags("Querie route");

        //retorna a quantidade de tasks concluidas
        Rota.MapGet("/concluidas", async ([FromServices]IMediator M) =>
        {
            return await M.Send(new ContarTarefasConcluidasQuery());
        }).WithTags("Querie route");

        //retorna a quantidade de tasks pendentes
        Rota.MapGet("/pendentes" ,async ([FromServices]IMediator M) =>
        {
            return await M.Send(new ContarTarefasPendentesQuery());
        }).WithTags("Querie route");
        //retorna a porcentagem de concluidas em relacao ao total de tasks
        Rota.MapGet ("/porcent" , async([FromServices]IMediator M) =>
        {
            return await M.Send(new PorcentagemConcluidaRelacionadoAoTotalQuery());
            
        }).WithTags("Querie route");

    }
}