using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesBusiness.Migrations
{
    public partial class NewSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Business");

            migrationBuilder.AddColumn<int>(
                name: "TypeID",
                table: "Business",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BusinessType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessType", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Business_TypeID",
                table: "Business",
                column: "TypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Business_BusinessType_TypeID",
                table: "Business",
                column: "TypeID",
                principalTable: "BusinessType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Business_BusinessType_TypeID",
                table: "Business");

            migrationBuilder.DropTable(
                name: "BusinessType");

            migrationBuilder.DropIndex(
                name: "IX_Business_TypeID",
                table: "Business");

            migrationBuilder.DropColumn(
                name: "TypeID",
                table: "Business");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Business",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
