namespace Aplicacao.Tarefas.ContarTarefasConcluidas.QueryHandler;
using Aplicacao.Tarefas.ContarTarefasConcluidas.Query;
using MediatR;
using Dominio.Interfaces.Interface;
public class ContarTarefasConcluidasQueryHandler : IRequestHandler<ContarTarefasConcluidasQuery, int>
{
    
        public ContarTarefasConcluidasQueryHandler(ITarefasRepositorio task)
         {
             c = task;
         }

    private readonly ITarefasRepositorio c;
    public async Task<int> Handle(ContarTarefasConcluidasQuery request, CancellationToken cancellationToken)
    {
        return await ContarTarefasConcluidas();
    }

    public async System.Threading.Tasks.Task<int> ContarTarefasConcluidas()
        {

            try
            {
                int QtdConcluidas = await c.ContarTarefasConcluidoAsync();  
                return QtdConcluidas;
            }

            catch
            {
                throw new Exception("Erro ao instanciar objeto");
            }
    }

}
