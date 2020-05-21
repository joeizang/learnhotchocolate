using Microsoft.EntityFrameworkCore.Migrations;

namespace learnhotchocolate.Migrations
{
    public partial class ChangesToModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Incomes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Incomes",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
