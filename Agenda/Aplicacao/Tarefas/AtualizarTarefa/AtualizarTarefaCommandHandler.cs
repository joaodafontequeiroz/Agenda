namespace Aplicacao.Tarefas.AtualizarTarefa.QueryHandler;
using Aplicacao.Tarefas.AtualizarTarefa.Query;
using MediatR;
using Dominio.Interfaces.Interface;
public class AtualizarTarefaCommandHandler : IRequestHandler<AtualizarTarefaCommand, bool>
  {
    
     public AtualizarTarefaCommandHandler(ITarefasRepositorio task)
         {
            c = task;
        }
    private readonly ITarefasRepositorio c;
    public async Task<bool> Handle(AtualizarTarefaCommand request, CancellationToken cancellationToken)
    {
        var resultado = await c.AtualizarTarefaAsync(request.Id, request.Hora, request.Classe, request.Titulo, request.Corpo, request.Concluido);
        return resultado;  
    }
}
  