using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class imagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "urlImagem",
                table: "PRODUTO",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "urlImagem",
                table: "PRODUTO");
        }
    }
}
