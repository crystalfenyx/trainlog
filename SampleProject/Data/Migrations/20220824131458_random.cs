using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SampleProject.Data.Migrations
{
    public partial class random : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpottingRecords_TrainsetLogs_TrainsetLogTrainset",
                table: "SpottingRecords");

            migrationBuilder.DropIndex(
                name: "IX_SpottingRecords_TrainsetLogTrainset",
                table: "SpottingRecords");

            migrationBuilder.DropColumn(
                name: "TrainsetLogTrainset",
                table: "SpottingRecords");

            migrationBuilder.RenameColumn(
                name: "TrainsetSpottedID",
                table: "SpottingRecords",
                newName: "TrainsetForeignKey");

            migrationBuilder.InsertData(
                table: "SpottingRecords",
                columns: new[] { "SpottingRecordID", "TrainsetForeignKey" },
                values: new object[] { "MRT93742", 714 });

            migrationBuilder.CreateIndex(
                name: "IX_SpottingRecords_TrainsetForeignKey",
                table: "SpottingRecords",
                column: "TrainsetForeignKey");

            migrationBuilder.AddForeignKey(
                name: "FK_SpottingRecords_TrainsetLogs_TrainsetForeignKey",
                table: "SpottingRecords",
                column: "TrainsetForeignKey",
                principalTable: "TrainsetLogs",
                principalColumn: "Trainset");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpottingRecords_TrainsetLogs_TrainsetForeignKey",
                table: "SpottingRecords");

            migrationBuilder.DropIndex(
                name: "IX_SpottingRecords_TrainsetForeignKey",
                table: "SpottingRecords");

            migrationBuilder.DeleteData(
                table: "SpottingRecords",
                keyColumn: "SpottingRecordID",
                keyValue: "MRT93742");

            migrationBuilder.RenameColumn(
                name: "TrainsetForeignKey",
                table: "SpottingRecords",
                newName: "TrainsetSpottedID");

            migrationBuilder.AddColumn<int>(
                name: "TrainsetLogTrainset",
                table: "SpottingRecords",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SpottingRecords_TrainsetLogTrainset",
                table: "SpottingRecords",
                column: "TrainsetLogTrainset");

            migrationBuilder.AddForeignKey(
                name: "FK_SpottingRecords_TrainsetLogs_TrainsetLogTrainset",
                table: "SpottingRecords",
                column: "TrainsetLogTrainset",
                principalTable: "TrainsetLogs",
                principalColumn: "Trainset");
        }
    }
}
