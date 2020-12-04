using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Backend.Migrations
{
    public partial class comentarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "COMENTARIOS",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    produtoId = table.Column<long>(nullable: false),
                    comentario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMENTARIOS", x => x.id);
                    table.ForeignKey(
                        name: "FK_COMENTARIOS_PRODUTO_produtoId",
                        column: x => x.produtoId,
                        principalTable: "PRODUTO",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_COMENTARIOS_produtoId",
                table: "COMENTARIOS",
                column: "produtoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "COMENTARIOS");
        }
    }
}
