using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GMIS.Migrations
{
    public partial class bugfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpUsers_UserProjects_UserProjectId",
                table: "AbpUsers");

            migrationBuilder.DropIndex(
                name: "IX_AbpUsers_UserProjectId",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "UserProjectId",
                table: "AbpUsers");

            migrationBuilder.CreateIndex(
                name: "IX_UserProjects_UserId",
                table: "UserProjects",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserProjects_AbpUsers_UserId",
                table: "UserProjects",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProjects_AbpUsers_UserId",
                table: "UserProjects");

            migrationBuilder.DropIndex(
                name: "IX_UserProjects_UserId",
                table: "UserProjects");

            migrationBuilder.AddColumn<Guid>(
                name: "UserProjectId",
                table: "AbpUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_UserProjectId",
                table: "AbpUsers",
                column: "UserProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUsers_UserProjects_UserProjectId",
                table: "AbpUsers",
                column: "UserProjectId",
                principalTable: "UserProjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
