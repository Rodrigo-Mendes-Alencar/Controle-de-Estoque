using Controle_de_Estoque.Models;
using Controle_de_Estoque.Data;
namespace Controle_de_Estoque.Repository
{
    public class CategoriaRepository : ICategoriaRepositery
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }
        public Categoria BuscarCategoriaPorId(int id)
        {
            return _context.Categorias.Find(id);
        }

        public void CadastrarCategoria(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
        }

        public void ExcluirCategoria(int id)
        {
            Categoria categoria = new Categoria { Id = id };
            _context.Categorias.Remove(categoria);
            _context.SaveChanges();
        }

        public List<Categoria> ListarCategorias()
        {
            return _context.Categorias.ToList();
        }

        public void AtualizarCategoria(Categoria categoria)
        {
            _context.Categorias.Update(categoria);
        }
    }
}
