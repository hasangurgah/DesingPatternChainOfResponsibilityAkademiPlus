using Microsoft.EntityFrameworkCore;

namespace DesingPatternChainOfResponsibilityAkademiPlus.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-7UJ1ONJ\\SQLEXPRESS;initial catalog=AkademiPlusChainOfRespDb;integrated security=true");
        }
        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
