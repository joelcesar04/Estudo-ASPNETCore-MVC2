using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JcIO.Site.Migrations
{
    /// <inheritdoc />
    public partial class RemoveTeste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Teste",
                table: "Alunos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Teste",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
