using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GMIS.Migrations
{
    public partial class bugfoundinProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DOI_Project_DOI_ProjectInfo_ProjectInfoId",
                table: "DOI_Project");

            migrationBuilder.DropIndex(
                name: "IX_DOI_Project_ProjectInfoId",
                table: "DOI_Project");

            migrationBuilder.DropColumn(
                name: "ProjectInfoId",
                table: "DOI_Project");

            migrationBuilder.AddColumn<Guid>(
                name: "ProjectId",
                table: "DOI_ProjectInfo",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_DOI_ProjectInfo_ProjectId",
                table: "DOI_ProjectInfo",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_DOI_ProjectInfo_DOI_Project_ProjectId",
                table: "DOI_ProjectInfo",
                column: "ProjectId",
                principalTable: "DOI_Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DOI_ProjectInfo_DOI_Project_ProjectId",
                table: "DOI_ProjectInfo");

            migrationBuilder.DropIndex(
                name: "IX_DOI_ProjectInfo_ProjectId",
                table: "DOI_ProjectInfo");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "DOI_ProjectInfo");

            migrationBuilder.AddColumn<int>(
                name: "ProjectInfoId",
                table: "DOI_Project",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DOI_Project_ProjectInfoId",
                table: "DOI_Project",
                column: "ProjectInfoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DOI_Project_DOI_ProjectInfo_ProjectInfoId",
                table: "DOI_Project",
                column: "ProjectInfoId",
                principalTable: "DOI_ProjectInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
