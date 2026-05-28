using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Controle_de_Estoque.Migrations
{
    /// <inheritdoc />
    public partial class alteracao_atributo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "quantidade",
                table: "Produtos",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "preco",
                table: "Produtos",
                newName: "Preco");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Produtos",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Produtos",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "Produtos",
                newName: "quantidade");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Produtos",
                newName: "preco");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Produtos",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Produtos",
                newName: "id");
        }
    }
}
