namespace Controle_de_Estoque.Repository
{
    using Controle_de_Estoque.Models;
    public interface IProdutoRepositery
    {
        public void SalvarProduto(Produto produto);
        public void BuscarProduto(int id);
        public void ApagarProduto(int id);
    }
}
