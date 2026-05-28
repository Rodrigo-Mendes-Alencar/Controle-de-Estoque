namespace Controle_de_Estoque.Model
{
    public class Produto
    {
        public String nome { get; set; }
        public float preco { get; set; }
        public int quantidade { get; set; }
        public Categoria categoria { get; set; }


        public Produto(string nome, float preco, int quantidade, Categoria categoria)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
            this.categoria = categoria;
        }

        public Produto()
        {
        }

    }
}
