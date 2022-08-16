using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SampleProject.Data.Migrations
{
    public partial class EditDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainsetLog",
                table: "TrainsetLog");

            migrationBuilder.RenameTable(
                name: "TrainsetLog",
                newName: "TrainsetLogs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainsetLogs",
                table: "TrainsetLogs",
                column: "Trainset");

            migrationBuilder.UpdateData(
                table: "TrainsetLogs",
                keyColumn: "Trainset",
                keyValue: 609,
                column: "Date",
                value: new DateTime(2022, 8, 16, 14, 53, 31, 697, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.InsertData(
                table: "TrainsetLogs",
                columns: new[] { "Trainset", "Date", "DisplayRunNo", "DisplayTrainset", "Line", "Line2", "Remarks", "RollingStock", "RunNo", "Trainset2", "Trainset3" },
                values: new object[] { 223, new DateTime(2022, 8, 16, 14, 53, 31, 697, DateTimeKind.Local).AddTicks(5757), "T211", "223/224", "NSL", "EWL", "Train", "C651", 211, 224, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainsetLogs",
                table: "TrainsetLogs");

            migrationBuilder.DeleteData(
                table: "TrainsetLogs",
                keyColumn: "Trainset",
                keyValue: 223);

            migrationBuilder.RenameTable(
                name: "TrainsetLogs",
                newName: "TrainsetLog");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainsetLog",
                table: "TrainsetLog",
                column: "Trainset");

            migrationBuilder.UpdateData(
                table: "TrainsetLog",
                keyColumn: "Trainset",
                keyValue: 609,
                column: "Date",
                value: new DateTime(2022, 8, 16, 13, 0, 35, 349, DateTimeKind.Local).AddTicks(7683));
        }
    }
}
