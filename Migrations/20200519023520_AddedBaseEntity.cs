using Microsoft.EntityFrameworkCore.Migrations;

namespace learnhotchocolate.Migrations
{
    public partial class AddedBaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incomes_IncomeCategories_IncomeCategoryId",
                table: "Incomes");

            migrationBuilder.DropForeignKey(
                name: "FK_Incomes_IncomeCategories_IncomeCategoryId1",
                table: "Incomes");

            migrationBuilder.DropForeignKey(
                name: "FK_Incomes_IncomeSources_IncomeSourceid",
                table: "Incomes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IncomeSources",
                table: "IncomeSources");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Incomes",
                table: "Incomes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IncomeCategories",
                table: "IncomeCategories");

            migrationBuilder.DropColumn(
                name: "IncomeSourceId",
                table: "IncomeSources");

            migrationBuilder.DropColumn(
                name: "IncomeId",
                table: "Incomes");

            migrationBuilder.DropColumn(
                name: "IncomeCategoryId",
                table: "IncomeCategories");

            migrationBuilder.RenameColumn(
                name: "IncomeSourceid",
                table: "Incomes",
                newName: "IncomeSourceId");

            migrationBuilder.RenameIndex(
                name: "IX_Incomes_IncomeSourceid",
                table: "Incomes",
                newName: "IX_Incomes_IncomeSourceId");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "IncomeSources",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Incomes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "IncomeCategories",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IncomeSources",
                table: "IncomeSources",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Incomes",
                table: "Incomes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IncomeCategories",
                table: "IncomeCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Incomes_IncomeCategories_IncomeCategoryId",
                table: "Incomes",
                column: "IncomeCategoryId",
                principalTable: "IncomeCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Incomes_IncomeCategories_IncomeCategoryId1",
                table: "Incomes",
                column: "IncomeCategoryId1",
                principalTable: "IncomeCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Incomes_IncomeSources_IncomeSourceId",
                table: "Incomes",
                column: "IncomeSourceId",
                principalTable: "IncomeSources",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incomes_IncomeCategories_IncomeCategoryId",
                table: "Incomes");

            migrationBuilder.DropForeignKey(
                name: "FK_Incomes_IncomeCategories_IncomeCategoryId1",
                table: "Incomes");

            migrationBuilder.DropForeignKey(
                name: "FK_Incomes_IncomeSources_IncomeSourceId",
                table: "Incomes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IncomeSources",
                table: "IncomeSources");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Incomes",
                table: "Incomes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IncomeCategories",
                table: "IncomeCategories");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "IncomeSources");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Incomes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "IncomeCategories");

            migrationBuilder.RenameColumn(
                name: "IncomeSourceId",
                table: "Incomes",
                newName: "IncomeSourceid");

            migrationBuilder.RenameIndex(
                name: "IX_Incomes_IncomeSourceId",
                table: "Incomes",
                newName: "IX_Incomes_IncomeSourceid");

            migrationBuilder.AddColumn<string>(
                name: "IncomeSourceId",
                table: "IncomeSources",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IncomeId",
                table: "Incomes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IncomeCategoryId",
                table: "IncomeCategories",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IncomeSources",
                table: "IncomeSources",
                column: "IncomeSourceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Incomes",
                table: "Incomes",
                column: "IncomeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IncomeCategories",
                table: "IncomeCategories",
                column: "IncomeCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Incomes_IncomeCategories_IncomeCategoryId",
                table: "Incomes",
                column: "IncomeCategoryId",
                principalTable: "IncomeCategories",
                principalColumn: "IncomeCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Incomes_IncomeCategories_IncomeCategoryId1",
                table: "Incomes",
                column: "IncomeCategoryId1",
                principalTable: "IncomeCategories",
                principalColumn: "IncomeCategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Incomes_IncomeSources_IncomeSourceid",
                table: "Incomes",
                column: "IncomeSourceid",
                principalTable: "IncomeSources",
                principalColumn: "IncomeSourceId");
        }
    }
}
