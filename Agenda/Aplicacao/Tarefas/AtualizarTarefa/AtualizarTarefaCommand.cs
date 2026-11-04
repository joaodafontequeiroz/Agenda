namespace Aplicacao.Tarefas.AtualizarTarefa.Query;
using MediatR;

public class AtualizarTarefaCommand : IRequest<bool>
{
  public Guid Id {get; set;}
  public required String Hora {get; set;} 
  public required String Classe { get; set; }
  public required String Titulo { get; set; }
  public required String Corpo {get; set;}
  public bool Concluido {get; set;}
}

