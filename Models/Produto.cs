namespace Controle_de_Estoque.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }
        public Categoria categoria { get; set; }


        public Produto(string nome, float preco, int quantidade, Categoria categoria, int id)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
            this.categoria = categoria;
            this.Id = id;
        }

        public Produto()
        {
        }

    }
}
