namespace Controle_de_Estoque.Model
{
    public class Categoria
    {
        public int Id { get; set; }
        public String tipo { get; set; }

        public Categoria(int id, string tipo)
        {
            Id = id;
            this.tipo = tipo;
        }

        public Categoria()
        {
        }

    }
}
