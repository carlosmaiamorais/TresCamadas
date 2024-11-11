using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TresCamadas.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarColunaCpf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "CLIENTE",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "CLIENTE");
        }
    }
}
