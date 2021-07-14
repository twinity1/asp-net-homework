using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPHomework.Migrations
{
    public partial class OrderDestinationTerm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Destinations_DestinationId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_DestinationId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DestinationId",
                table: "Orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DestinationId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DestinationId",
                table: "Orders",
                column: "DestinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Destinations_DestinationId",
                table: "Orders",
                column: "DestinationId",
                principalTable: "Destinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
