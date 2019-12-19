using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MeetingPlanner.Migrations
{
    public partial class TopicsClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Meeting",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TopicName",
                table: "Meeting",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "TopicName",
                table: "Meeting");
        }
    }
}
