using Microsoft.EntityFrameworkCore;
using Controle_de_Estoque.Models;

namespace Controle_de_Estoque.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
            public DbSet<Produto> Produtos { get; set; }
            public DbSet<Categoria> Categorias { get; set; }
    }
        
}
