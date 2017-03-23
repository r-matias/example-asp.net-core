using Microsoft.EntityFrameworkCore;
using WebApi.Teste.Entities;

namespace WebApi.Teste.Repository.Context
{
    public class WebApiTesteContext : DbContext
    {
        public WebApiTesteContext(DbContextOptions<WebApiTesteContext> options) 
			: base(options)
        {
        }

        public DbSet<Log> Logs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Log>().ToTable("Log");
        }
    }
}
