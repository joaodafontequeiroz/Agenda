namespace Aplicacao.Tarefas.ListarTarefas.QueryHandler;
using Aplicacao.Tarefas.ListarTarefas.Query;
using Dominio.Entidades.Tarefa; 
using MediatR;
using Dominio.Interfaces.Interface;
public class ListarTarefasQueryHandler : IRequestHandler<ListarTarefasQuery, List<Tarefa>>
 {
    
    
    private readonly ITarefasRepositorio TarefaR;
    public ListarTarefasQueryHandler(ITarefasRepositorio Tarefa)
        {
            TarefaR = Tarefa;
        }
    public async Task<List<Tarefa>> Handle(ListarTarefasQuery request, CancellationToken cancellationToken)
    {
        return await ListarTarefass(); 
    }

    public async Task <List<Tarefa>> ListarTarefass()
    {

        try
        {
                return await TarefaR.ListarTodasAsync();    
        }

        catch
        {
                throw new Exception("Erro ao instanciar objeto");
        }
   }
 }
 