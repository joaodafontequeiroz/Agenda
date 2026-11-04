namespace Aplicacao.Tarefas.AdicionarTarefa.Query;
using MediatR;
public class AdicionarTarefaCommand : IRequest<bool>
{
    public required string Hora { get; set; }
    public required string Classe { get; set; }
    public required string Titulo { get; set; }
    public required string Corpo { get; set; }
    public required bool Concluido { get; set; }
};