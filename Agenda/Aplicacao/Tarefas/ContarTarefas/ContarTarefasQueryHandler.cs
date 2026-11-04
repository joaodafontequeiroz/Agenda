namespace Aplicacao.Tarefas.ContarTarefas.QueryHandler;
using Dominio.Interfaces.Interface;using MediatR; 
using Aplicacao.Tarefas.ContarTarefas.Query;

public class ContarTarefasQueryHandler : IRequestHandler<ContarTarefasQuery, int> 
 {
    public async Task<int> Handle(ContarTarefasQuery request, CancellationToken cancellationToken)
    {
        return await ContarTarefas();
    }

    public ContarTarefasQueryHandler(ITarefasRepositorio task)
        {
            c = task;
        }

    private readonly ITarefasRepositorio c;
    public async System.Threading.Tasks.Task<int> ContarTarefas()
    {

            try
            {
                int QtdTarefas = await c.ContarTarefasAsync();  
                return QtdTarefas;
            }

            catch
            {
                throw new Exception("Erro ao instanciar objeto");
            }
    }

    
}
 