using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_C8orsAccepted4Project_Collabor8ors_Collabor8orId",
                table: "C8orsAccepted4Project");

            migrationBuilder.DropColumn(
                name: "C8orId",
                table: "C8orsProjects");

            migrationBuilder.DropColumn(
                name: "C8orId",
                table: "C8orsAccepted4Project");

            migrationBuilder.AlterColumn<int>(
                name: "Collabor8orId",
                table: "C8orsAccepted4Project",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_C8orsAccepted4Project_Collabor8ors_Collabor8orId",
                table: "C8orsAccepted4Project",
                column: "Collabor8orId",
                principalTable: "Collabor8ors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_C8orsAccepted4Project_Collabor8ors_Collabor8orId",
                table: "C8orsAccepted4Project");

            migrationBuilder.AddColumn<int>(
                name: "C8orId",
                table: "C8orsProjects",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Collabor8orId",
                table: "C8orsAccepted4Project",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "C8orId",
                table: "C8orsAccepted4Project",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_C8orsAccepted4Project_Collabor8ors_Collabor8orId",
                table: "C8orsAccepted4Project",
                column: "Collabor8orId",
                principalTable: "Collabor8ors",
                principalColumn: "Id");
        }
    }
}
