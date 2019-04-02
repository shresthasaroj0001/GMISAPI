using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GMIS.Migrations
{
    public partial class _projectInfoss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserTokens_AbpUsers_UserId",
                table: "AbpUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProjects_AbpUsers_UserId",
                table: "UserProjects");

            migrationBuilder.DropIndex(
                name: "IX_UserProjects_UserId",
                table: "UserProjects");

            migrationBuilder.DropIndex(
                name: "IX_AbpUserTokens_UserId",
                table: "AbpUserTokens");

            migrationBuilder.AddColumn<long>(
                name: "ProjectUserId",
                table: "UserProjects",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectInfoId",
                table: "DOI_Project",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "AbpUser<User>Id",
                table: "AbpUserTokens",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AbpUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "DOI_Info_ProjectStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Order = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOI_Info_ProjectStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DOI_ProjectInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    commandarea_gca = table.Column<decimal>(nullable: false),
                    commandarea_nca = table.Column<decimal>(nullable: false),
                    mgmt_system = table.Column<string>(nullable: true),
                    mgmt_system_other = table.Column<string>(nullable: true),
                    project_type = table.Column<string>(nullable: true),
                    project_comment = table.Column<string>(nullable: true),
                    other_info_prepared_by = table.Column<string>(nullable: true),
                    other_info_approved_by = table.Column<string>(nullable: true),
                    other_info_recommended_by = table.Column<string>(nullable: true),
                    IsPhaseCompleted = table.Column<bool>(nullable: false),
                    approved_date = table.Column<DateTime>(nullable: false),
                    start_date = table.Column<DateTime>(nullable: false),
                    end_date = table.Column<DateTime>(nullable: false),
                    ProgramInformationId = table.Column<int>(nullable: false),
                    ProgramTypeId = table.Column<int>(nullable: false),
                    ProjectStatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOI_ProjectInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DOI_ProjectInfo_DOI_Info_ProgramInfo_ProgramInformationId",
                        column: x => x.ProgramInformationId,
                        principalTable: "DOI_Info_ProgramInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DOI_ProjectInfo_DOI_Info_ProgramType_ProgramTypeId",
                        column: x => x.ProgramTypeId,
                        principalTable: "DOI_Info_ProgramType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DOI_ProjectInfo_DOI_Info_ProjectStatus_ProjectStatusId",
                        column: x => x.ProjectStatusId,
                        principalTable: "DOI_Info_ProjectStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserProjects_ProjectUserId",
                table: "UserProjects",
                column: "ProjectUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DOI_Project_ProjectInfoId",
                table: "DOI_Project",
                column: "ProjectInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserTokens_AbpUser<User>Id",
                table: "AbpUserTokens",
                column: "AbpUser<User>Id");

            migrationBuilder.CreateIndex(
                name: "IX_DOI_ProjectInfo_ProgramInformationId",
                table: "DOI_ProjectInfo",
                column: "ProgramInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_DOI_ProjectInfo_ProgramTypeId",
                table: "DOI_ProjectInfo",
                column: "ProgramTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DOI_ProjectInfo_ProjectStatusId",
                table: "DOI_ProjectInfo",
                column: "ProjectStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserTokens_AbpUsers_AbpUser<User>Id",
                table: "AbpUserTokens",
                column: "AbpUser<User>Id",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DOI_Project_DOI_ProjectInfo_ProjectInfoId",
                table: "DOI_Project",
                column: "ProjectInfoId",
                principalTable: "DOI_ProjectInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProjects_AbpUsers_ProjectUserId",
                table: "UserProjects",
                column: "ProjectUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserTokens_AbpUsers_AbpUser<User>Id",
                table: "AbpUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_DOI_Project_DOI_ProjectInfo_ProjectInfoId",
                table: "DOI_Project");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProjects_AbpUsers_ProjectUserId",
                table: "UserProjects");

            migrationBuilder.DropTable(
                name: "DOI_ProjectInfo");

            migrationBuilder.DropTable(
                name: "DOI_Info_ProjectStatus");

            migrationBuilder.DropIndex(
                name: "IX_UserProjects_ProjectUserId",
                table: "UserProjects");

            migrationBuilder.DropIndex(
                name: "IX_DOI_Project_ProjectInfoId",
                table: "DOI_Project");

            migrationBuilder.DropIndex(
                name: "IX_AbpUserTokens_AbpUser<User>Id",
                table: "AbpUserTokens");

            migrationBuilder.DropColumn(
                name: "ProjectUserId",
                table: "UserProjects");

            migrationBuilder.DropColumn(
                name: "ProjectInfoId",
                table: "DOI_Project");

            migrationBuilder.DropColumn(
                name: "AbpUser<User>Id",
                table: "AbpUserTokens");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AbpUsers");

            migrationBuilder.CreateIndex(
                name: "IX_UserProjects_UserId",
                table: "UserProjects",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserTokens_UserId",
                table: "AbpUserTokens",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserTokens_AbpUsers_UserId",
                table: "AbpUserTokens",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProjects_AbpUsers_UserId",
                table: "UserProjects",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
