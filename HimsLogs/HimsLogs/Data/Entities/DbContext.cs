using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;

namespace HimsLogs.Data.Entities
{
    public class Context : DbContext
    {

        public Context() : base() { }
        public DbSet<Log> Logs { get; set; }
        

        public Context(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server = localhost; Database = LogsModel; User = root; Password = Hiba@123");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure YourEntity primary key
            modelBuilder.Entity<Log>().HasKey(e => e.Id);
            


            base.OnModelCreating(modelBuilder);
        }


    }
}