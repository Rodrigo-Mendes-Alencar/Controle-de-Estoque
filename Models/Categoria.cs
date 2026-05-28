namespace Controle_de_Estoque.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public String Nome { get; set; }

        public Categoria(int id, string tipo)
        {
            Id = id;
            this.Nome = tipo;
        }

        public Categoria()
        {
        }

    }
}
