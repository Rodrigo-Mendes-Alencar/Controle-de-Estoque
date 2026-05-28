namespace Controle_de_Estoque.Repository
{
    using Controle_de_Estoque.Models;
    public interface IProdutoRepositery
    {
        public void CadastrarProduto(Produto produto);
        public Produto BuscarProduto(int id);
        public void ApagarProduto(int id);
        public List<Produto> ListarProdutos();
        public void AtualizarProduto(Produto produto);
    }
}
