using Microsoft.EntityFrameworkCore.Migrations;

namespace MeetingPlanner.Migrations
{
    public partial class SpeakerTopicChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SpeakerID",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopicID",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Meeting",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_SpeakerID",
                table: "Meeting",
                column: "SpeakerID");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_TopicID",
                table: "Meeting",
                column: "TopicID");

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_Meeting_SpeakerID",
                table: "Meeting",
                column: "SpeakerID",
                principalTable: "Meeting",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_Meeting_TopicID",
                table: "Meeting",
                column: "TopicID",
                principalTable: "Meeting",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_Meeting_SpeakerID",
                table: "Meeting");

            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_Meeting_TopicID",
                table: "Meeting");

            migrationBuilder.DropIndex(
                name: "IX_Meeting_SpeakerID",
                table: "Meeting");

            migrationBuilder.DropIndex(
                name: "IX_Meeting_TopicID",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "SpeakerID",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "TopicID",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Meeting");
        }
    }
}
