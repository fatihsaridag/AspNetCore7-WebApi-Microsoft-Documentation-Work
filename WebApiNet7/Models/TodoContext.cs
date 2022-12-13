using Microsoft.EntityFrameworkCore;

namespace WebApiNet7.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;


    }
}
