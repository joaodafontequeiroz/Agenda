namespace Infra.Data.ContextTask;
using Microsoft.EntityFrameworkCore;
using Dominio.Entidades.Tarefa;

 public class TaskContext : DbContext
{
    public TaskContext (DbContextOptions<TaskContext> options) : base(options)
    {
    }
    public DbSet<Tarefa> ListaDeTarefas {get; set;}
}