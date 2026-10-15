namespace Data.ContextTask;
using Microsoft.EntityFrameworkCore;
using Models.Task;

 public class TaskContext : DbContext
{
    public TaskContext (DbContextOptions<TaskContext> options) : base(options)
    {
    }

    public DbSet<Task> Tasks {get; set;}
}