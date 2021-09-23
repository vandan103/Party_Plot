using Microsoft.EntityFrameworkCore.Migrations;

namespace ParttyPlotSystem.Data.Migrations
{
    public partial class AddedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Payment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
