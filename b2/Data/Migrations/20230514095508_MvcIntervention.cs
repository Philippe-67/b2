using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace b2.Data.Migrations
{
    /// <inheritdoc />
    public partial class MvcIntervention : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Intervention",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionIntervention = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeuxiemeIntervention = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intervention", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Intervention");
        }
    }
}
