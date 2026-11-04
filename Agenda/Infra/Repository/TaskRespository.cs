namespace Infra.Repository.RepositorioTarefas;
using Infra.Data.ContextTask;
using Dominio.Entidades.Tarefa;
using Dominio.Interfaces.Interface;
using Microsoft.EntityFrameworkCore;

public class RepositorioTarefas : ITarefasRepositorio
{
    private readonly TaskContext contexto;
    public RepositorioTarefas (TaskContext _contexto)
    {
        contexto = _contexto;
    }    

    public async Task <List<Tarefa>> ListarTodasAsync()
    {
        try
        {
            return await contexto.ListaDeTarefas.AsNoTracking().ToListAsync();
        }

        catch
        {
            throw new Exception("Erro na operacao de buscar no banco");
        }
    }

    public async Task<int> ContarTarefasConcluidoAsync()
    {
        try
        {
            int QtdConcluidas = await contexto.ListaDeTarefas.AsNoTracking().CountAsync(t => t.Concluido == true); 
            return QtdConcluidas;

        }
        catch
        {
            throw new Exception("Erro na operacao ao contar concluidos no banco");
        }
    }

      public async Task<int> ContarTarefasNaoConcluido()
    {
        try
        {
            int QtdPendentes = await contexto.ListaDeTarefas.AsNoTracking().CountAsync(t => t.Concluido == false);
            return QtdPendentes;
        }
        catch
        {
            throw new Exception("Erro na operacao ao contar nao concluidos no banco");
        }
    }

    
    public async Task<int> ContarTarefasAsync()
    {
         try
        {
            int total = await contexto.ListaDeTarefas.AsNoTracking().CountAsync();
            return total;       
        }
        catch
        {
            throw new Exception("Erro na operacao ao contar tasks no banco");
        }
    }
        

    public async Task<bool> AdicionarAsync(String Hora, String Classe, String Titulo, String Corpo, bool Concluida)
    {
        try
        {   
            Tarefa t = new Tarefa(Hora, Classe, Titulo, Corpo, Concluida); 
            await contexto.ListaDeTarefas.AddAsync(t);
            await contexto.SaveChangesAsync(); 
            return true;   
        }

        catch
        {
            throw new Exception("Erro na operacao de adicionar ao banco");
        }
    }

    public async Task<bool> DeletarAsync (Guid Id)
    {
        try
        {
           await contexto.ListaDeTarefas.Where(t => t.Id == Id).ExecuteDeleteAsync();
           return true;
        }

        catch
        {
            throw new Exception("Erro na operacao de deletar por id no banco");
        }
    }

     public async Task <bool> AtualizarTarefaAsync(Guid id, String Hora, String Classe, String Titulo, String Corpo, bool Concluido)
    {
        try
        {
            var linhas = await contexto.ListaDeTarefas
                .Where(t => t.Id == id)
                .ExecuteUpdateAsync(s => s
                    .SetProperty(t => t.Hora, Hora)
                    .SetProperty(t => t.Classe, Classe)
                    .SetProperty(t => t.Titulo, Titulo)
                    .SetProperty(t => t.Corpo, Corpo)
                    .SetProperty(t => t.Concluido, Concluido));

            return true;
        }

        catch
        {
            throw new Exception("Erro na operacao ao atualizar o banco");
        }
    }    
}

    
