using MediatR;
using Dominio.Entidades.Tarefa;
namespace Aplicacao.Tarefas.ListarTarefas.Query;

    
public class ListarTarefasQuery : IRequest<List<Tarefa>>
{
}