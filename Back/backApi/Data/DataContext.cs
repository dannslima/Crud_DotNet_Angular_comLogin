using Microsoft.EntityFrameworkCore;

namespace backApi.Models
{
    
    public class DataContext : DbContext
    {
        public DbSet<UsuarioModel> Usuarios { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Banco.sqlite");

            base.OnConfiguring(optionsBuilder);


        }
      
    }
}
