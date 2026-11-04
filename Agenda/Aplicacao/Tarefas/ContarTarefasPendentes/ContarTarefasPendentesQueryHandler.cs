namespace Aplicacao.Tarefas.ContarTarefasPendentes.QueryHandler;
using Aplicacao.Tarefas.ContarTarefasPendentes.Query;
using MediatR;
using Infra.Repository.RepositorioTarefas;
using Dominio.Interfaces.Interface;
public class ContarTarefasPendentesQueryHandler : IRequestHandler<ContarTarefasPendentesQuery, int>
{
    public async Task<int> Handle(ContarTarefasPendentesQuery request, CancellationToken cancellationToken)
    {
        return await ContarTarefasPendentes();
    }
    public ContarTarefasPendentesQueryHandler(ITarefasRepositorio task)
        {
            c = task;
        } 
    private readonly ITarefasRepositorio c;
    public async System.Threading.Tasks.Task<int> ContarTarefasPendentes()
        {

            try
            {
                int QtdPendentes = await c.ContarTarefasNaoConcluido();  
                return QtdPendentes;
            }

            catch
            {
                throw new Exception("Erro ao instanciar objeto");
            }
    }

}
