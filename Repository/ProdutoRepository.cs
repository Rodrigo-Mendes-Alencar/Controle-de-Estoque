using Controle_de_Estoque.Data;
using Controle_de_Estoque.Models;

namespace Controle_de_Estoque.Repository
{
    public class ProdutoRepository : IProdutoRepositery
    {

        private readonly AppDbContext _context;
        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public void ApagarProduto(int id)
        {
            //cria objeto "fantasma" com o ID fornecido pra evitar consulta desnecessária ao banco
            var produto = new Produto { Id = id }; 
            _context.Produtos.Remove(produto);//remove usa o id do objeto "fantasma" para deletar o registro correspondente
            _context.SaveChanges();
        }

        public Produto BuscarProduto(int id)
        {
            return _context.Produtos.Find(id);
        }

        public List<Produto> ListarProdutos()
        {
            return _context.Produtos.ToList();
        }

        public void CadastrarProduto(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }
        public void AtualizarProduto(Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }


    }
}
