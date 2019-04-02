using Microsoft.EntityFrameworkCore.Migrations;

namespace GMIS.Migrations
{
    public partial class BasicProjectEntityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DOI_Project_DOI_Info_ProgramInfo_ProgramInformationId",
                table: "DOI_Project");

            migrationBuilder.DropForeignKey(
                name: "FK_DOI_Project_DOI_Info_ProgramType_ProgramTypeId",
                table: "DOI_Project");

            migrationBuilder.DropIndex(
                name: "IX_DOI_Project_ProgramInformationId",
                table: "DOI_Project");

            migrationBuilder.DropIndex(
                name: "IX_DOI_Project_ProgramTypeId",
                table: "DOI_Project");

            migrationBuilder.DropColumn(
                name: "ProgramInformationId",
                table: "DOI_Project");

            migrationBuilder.DropColumn(
                name: "ProgramTypeId",
                table: "DOI_Project");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProgramInformationId",
                table: "DOI_Project",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProgramTypeId",
                table: "DOI_Project",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DOI_Project_ProgramInformationId",
                table: "DOI_Project",
                column: "ProgramInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_DOI_Project_ProgramTypeId",
                table: "DOI_Project",
                column: "ProgramTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_DOI_Project_DOI_Info_ProgramInfo_ProgramInformationId",
                table: "DOI_Project",
                column: "ProgramInformationId",
                principalTable: "DOI_Info_ProgramInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DOI_Project_DOI_Info_ProgramType_ProgramTypeId",
                table: "DOI_Project",
                column: "ProgramTypeId",
                principalTable: "DOI_Info_ProgramType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
