namespace Aplicacao.Tarefas.PorcentagemConcluidaRelacionadoAoTotal.QueryHandler;
using Aplicacao.Tarefas.PorcentagemConcluidaRelacionadoAoTotal.Query;
using MediatR;
using Dominio.Interfaces.Interface;

public class PorcentagemConcluidaRelacionadoAoTotalQueryHandler : IRequestHandler<PorcentagemConcluidaRelacionadoAoTotalQuery, int>
 {
    private readonly ITarefasRepositorio ITarefas;
    public PorcentagemConcluidaRelacionadoAoTotalQueryHandler(ITarefasRepositorio _ITarefas)
        {
            ITarefas = _ITarefas;
        }

    public async Task<int> Handle(PorcentagemConcluidaRelacionadoAoTotalQuery request, CancellationToken cancellationToken)
    {
        return await Porcentagem();
    }

    public async Task<int> Porcentagem()
    {

        try
        {
            int QtdTarefas = await ITarefas.ContarTarefasAsync();  
            int QtdConcluidos = await ITarefas.ContarTarefasConcluidoAsync();
            if (QtdTarefas == 0) return 0;
            var porcentagem = ((100) * (QtdConcluidos)) / (QtdTarefas);
            return porcentagem;
        }

        catch
        {
            throw new Exception("Erro ao instanciar objeto");
        }
   }
 }
 