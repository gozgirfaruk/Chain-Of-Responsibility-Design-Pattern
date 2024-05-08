using Microsoft.EntityFrameworkCore;

namespace ChainOfRespProject.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-MT6QAH6\\SQLEXPRESS; initial catalog=DbChainResponsibility ; integrated security=true");

        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
