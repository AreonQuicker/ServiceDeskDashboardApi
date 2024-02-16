using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceDeskDashboardApi.Migrations
{
    public partial class Nullfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StageName",
                schema: "pbi",
                table: "pbi.WebHookRelease",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DeployReleaseDefinitionName",
                schema: "pbi",
                table: "pbi.WebHookRelease",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "DeployReleaseDefinitionId",
                schema: "pbi",
                table: "pbi.WebHookRelease",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StageName",
                schema: "pbi",
                table: "pbi.WebHookRelease",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeployReleaseDefinitionName",
                schema: "pbi",
                table: "pbi.WebHookRelease",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeployReleaseDefinitionId",
                schema: "pbi",
                table: "pbi.WebHookRelease",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
