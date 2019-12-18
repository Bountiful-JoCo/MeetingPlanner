using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MeetingPlanner.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SpeechDate = table.Column<DateTime>(nullable: false),
                    Topic = table.Column<string>(nullable: true),
                    ConductingLeader = table.Column<string>(maxLength: 60, nullable: false),
                    OpeningSong = table.Column<string>(nullable: true),
                    OpeningPrayer = table.Column<string>(maxLength: 60, nullable: false),
                    SacramentSong = table.Column<string>(nullable: true),
                    Speaker1 = table.Column<string>(maxLength: 120, nullable: true),
                    Speaker2 = table.Column<string>(maxLength: 120, nullable: true),
                    Speaker3 = table.Column<string>(maxLength: 120, nullable: true),
                    Speaker4 = table.Column<string>(maxLength: 120, nullable: true),
                    Speaker5 = table.Column<string>(maxLength: 120, nullable: true),
                    ClosingSong = table.Column<string>(nullable: true),
                    ClosingPrayer = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meeting");
        }
    }
}
