using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Database
{
    public class eCommerceContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=eCommerceUdemy;"));
        //}

        public eCommerceContext(DbContextOptions<eCommerceContext> options) : base (options) 
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<EnderecoEntrega> Enderecos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamento>().HasData(
                new Departamento { Id = 1, Nome = "Celulares"},
                new Departamento { Id = 2, Nome = "Informática"},
                new Departamento { Id = 3, Nome = "Moda"},
                new Departamento { Id = 4, Nome = "Eletrodomésticos"},
                new Departamento { Id = 5, Nome = "Eletroportáteis"},
                new Departamento { Id = 6, Nome = "Móveis"},
                new Departamento { Id = 7, Nome = "Beleza e Saúde"});
        }
    }
}
