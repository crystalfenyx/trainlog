using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SampleProject.Data.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TrainsetLog",
                columns: table => new
                {
                    Trainset = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Trainset2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Trainset3 = table.Column<int>(type: "INTEGER", nullable: false),
                    DisplayTrainset = table.Column<string>(type: "TEXT", nullable: false),
                    RollingStock = table.Column<string>(type: "TEXT", nullable: false),
                    Line = table.Column<string>(type: "TEXT", nullable: false),
                    Line2 = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RunNo = table.Column<int>(type: "INTEGER", nullable: false),
                    DisplayRunNo = table.Column<string>(type: "TEXT", nullable: false),
                    Remarks = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainsetLog", x => x.Trainset);
                });

            migrationBuilder.InsertData(
                table: "TrainsetLog",
                columns: new[] { "Trainset", "Date", "DisplayRunNo", "DisplayTrainset", "Line", "Line2", "Remarks", "RollingStock", "RunNo", "Trainset2", "Trainset3" },
                values: new object[] { 609, new DateTime(2022, 8, 16, 13, 0, 35, 349, DateTimeKind.Local).AddTicks(7683), "T211", "609/610", "NSL", "EWL", "Train", "C151B", 211, 610, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrainsetLog");
        }
    }
}
