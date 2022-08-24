using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SampleProject.Data.Migrations
{
    public partial class spottingrecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "TrainsetLogs");

            migrationBuilder.DropColumn(
                name: "DisplayRunNo",
                table: "TrainsetLogs");

            migrationBuilder.DropColumn(
                name: "RunNo",
                table: "TrainsetLogs");

            migrationBuilder.AlterColumn<int>(
                name: "Trainset3",
                table: "TrainsetLogs",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Trainset2",
                table: "TrainsetLogs",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "RollingStock",
                table: "TrainsetLogs",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "TrainsetLogs",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Line2",
                table: "TrainsetLogs",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Line",
                table: "TrainsetLogs",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayTrainset",
                table: "TrainsetLogs",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.CreateTable(
                name: "SpottingRecords",
                columns: table => new
                {
                    SpottingRecordID = table.Column<string>(type: "TEXT", nullable: false),
                    TrainsetSpottedID = table.Column<int>(type: "INTEGER", nullable: true),
                    TrainsetLogTrainset = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpottingRecords", x => x.SpottingRecordID);
                    table.ForeignKey(
                        name: "FK_SpottingRecords_TrainsetLogs_TrainsetLogTrainset",
                        column: x => x.TrainsetLogTrainset,
                        principalTable: "TrainsetLogs",
                        principalColumn: "Trainset");
                });

            migrationBuilder.UpdateData(
                table: "TrainsetLogs",
                keyColumn: "Trainset",
                keyValue: 223,
                column: "Line2",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_SpottingRecords_TrainsetLogTrainset",
                table: "SpottingRecords",
                column: "TrainsetLogTrainset");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpottingRecords");

            migrationBuilder.AlterColumn<int>(
                name: "Trainset3",
                table: "TrainsetLogs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Trainset2",
                table: "TrainsetLogs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RollingStock",
                table: "TrainsetLogs",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "TrainsetLogs",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Line2",
                table: "TrainsetLogs",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Line",
                table: "TrainsetLogs",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayTrainset",
                table: "TrainsetLogs",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "TrainsetLogs",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DisplayRunNo",
                table: "TrainsetLogs",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RunNo",
                table: "TrainsetLogs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TrainsetLogs",
                keyColumn: "Trainset",
                keyValue: 223,
                columns: new[] { "Date", "DisplayRunNo", "Line2", "RunNo" },
                values: new object[] { new DateTime(2022, 8, 16, 14, 53, 31, 697, DateTimeKind.Local).AddTicks(5757), "T211", "EWL", 211 });

            migrationBuilder.UpdateData(
                table: "TrainsetLogs",
                keyColumn: "Trainset",
                keyValue: 609,
                columns: new[] { "Date", "DisplayRunNo", "RunNo" },
                values: new object[] { new DateTime(2022, 8, 16, 14, 53, 31, 697, DateTimeKind.Local).AddTicks(5742), "T211", 211 });
        }
    }
}
