namespace Controle_de_Estoque.Repository
{
    using Controle_de_Estoque.Models;
    public interface ICategoriaRepositery
    {
        public List<Categoria> ListarCategorias();
        public Categoria BuscarCategoriaPorId(int id);
        public void CadastrarCategoria(Categoria categoria);
        public void ExcluirCategoria(int id);

        public void AtualizarCategoria(Categoria categoria);
    }
}
