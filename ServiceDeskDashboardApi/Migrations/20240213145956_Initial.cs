﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceDeskDashboardApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WebHookRelease",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReleaseCreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubscriptionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotificationId = table.Column<int>(type: "int", nullable: true),
                    EventType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetailedMessageText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResourceUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeploymentId = table.Column<int>(type: "int", nullable: false),
                    DeploymentReleaseId = table.Column<int>(type: "int", nullable: false),
                    DeploymentReleaseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeployReleaseDefinitionId = table.Column<int>(type: "int", nullable: false),
                    DeployReleaseDefinitionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeployReleaseEnvironmentId = table.Column<int>(type: "int", nullable: false),
                    DeployReleaseEnvironmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeployRequstedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeployRequestedForUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeployQueuedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeployStartedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeployCompletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeployApproveMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeployApproverUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeployApprovedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebHookRelease", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WebHookReleaseCommit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WebHookReleaseId = table.Column<int>(type: "int", nullable: false),
                    CommitId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommitMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommitAuthor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebHookReleaseCommit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WebHookReleaseCommit_WebHookRelease_WebHookReleaseId",
                        column: x => x.WebHookReleaseId,
                        principalTable: "WebHookRelease",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WebHookReleaseCommit_WebHookReleaseId",
                table: "WebHookReleaseCommit",
                column: "WebHookReleaseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WebHookReleaseCommit");

            migrationBuilder.DropTable(
                name: "WebHookRelease");
        }
    }
}
