using Microsoft.EntityFrameworkCore.Migrations;

namespace SpaceyWebbApp.Migrations
{
    public partial class Fixinfreignkeyrelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Expeditions_DestinationId",
                table: "Expeditions",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Expeditions_RocketId",
                table: "Expeditions",
                column: "RocketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expeditions_Destinations_DestinationId",
                table: "Expeditions",
                column: "DestinationId",
                principalTable: "Destinations",
                principalColumn: "DestinationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Expeditions_Rockets_RocketId",
                table: "Expeditions",
                column: "RocketId",
                principalTable: "Rockets",
                principalColumn: "RocketId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expeditions_Destinations_DestinationId",
                table: "Expeditions");

            migrationBuilder.DropForeignKey(
                name: "FK_Expeditions_Rockets_RocketId",
                table: "Expeditions");

            migrationBuilder.DropIndex(
                name: "IX_Expeditions_DestinationId",
                table: "Expeditions");

            migrationBuilder.DropIndex(
                name: "IX_Expeditions_RocketId",
                table: "Expeditions");
        }
    }
}
