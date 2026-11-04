namespace Aplicacao.Tarefas.DeletarTarefas.QueryHandler;
using MediatR;
using Aplicacao.Tarefas.DeletarTarefas.Query;
using Dominio.Interfaces.Interface;
public class DeletarTarefaCommandHandler : IRequestHandler<DeletarTarefaCommand, bool>
{

    public DeletarTarefaCommandHandler(ITarefasRepositorio task)
    {
        c = task;
    }
    private readonly ITarefasRepositorio c;
  public async Task<bool> Handle(DeletarTarefaCommand request, CancellationToken cancellationToken)
    {
        var resultado = await c.DeletarAsync(request.Id);
        return resultado;
    }
  
}
 