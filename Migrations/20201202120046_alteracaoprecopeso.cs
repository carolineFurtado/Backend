using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class alteracaoprecopeso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "preco",
                table: "PRODUTO",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<decimal>(
                name: "peso",
                table: "PRODUTO",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "preco",
                table: "PRODUTO",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<long>(
                name: "peso",
                table: "PRODUTO",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
