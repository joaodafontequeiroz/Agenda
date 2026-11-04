using Dominio.Entidades.Tarefa;

namespace Dominio.Interfaces.Interface;
public interface ITarefasRepositorio
{
    public Task<bool> AdicionarAsync(String Hora, String Classe, String Titulo, String Corpo, bool Concluida);
    public Task<bool> DeletarAsync(Guid id);
    public Task<bool> AtualizarTarefaAsync(Guid id, String Hora, String Classe, String Titulo, String Corpo, bool Concluido);
    public Task <List<Tarefa>> ListarTodasAsync();
    public Task<int> ContarTarefasConcluidoAsync();
    public Task<int> ContarTarefasNaoConcluido();
    public Task<int> ContarTarefasAsync();       
}
    


