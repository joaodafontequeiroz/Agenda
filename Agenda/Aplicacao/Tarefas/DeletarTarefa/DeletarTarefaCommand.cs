using MediatR;
namespace Aplicacao.Tarefas.DeletarTarefas.Query;
public class DeletarTarefaCommand : IRequest<bool>
{
    public Guid Id {get; set;}
}