namespace Controle_de_Estoque.Models
{
    public class Produto
    {
        public int id { get; set; }
        public String nome { get; set; }
        public float preco { get; set; }
        public int quantidade { get; set; }
        public Categoria categoria { get; set; }


        public Produto(string nome, float preco, int quantidade, Categoria categoria, int id)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
            this.categoria = categoria;
            this.id = id;
        }

        public Produto()
        {
        }

    }
}
