using Controle_de_Estoque.Models;
using Controle_de_Estoque.Data;


namespace Controle_de_Estoque.Repository
{
    public class ProdutoRepository : IProdutoRepositery
    {
        AppDbContext _context = new AppDbContext(options);
        public void ApagarProduto(int id)
        {
            throw new NotImplementedException();
        }

        public void BuscarProduto(int id)
        {
            _context.Produtos.Find(id);
        }

        public void SalvarProduto(Produto produto)
        {

        }
    }
}
