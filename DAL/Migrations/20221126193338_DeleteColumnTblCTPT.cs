using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class DeleteColumnTblCTPT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaCTPT",
                table: "CTPhieuThue");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MaCTPT",
                table: "CTPhieuThue",
                type: "nvarchar(10)",
                nullable: false,
                defaultValue: "");
        }
    }
}
