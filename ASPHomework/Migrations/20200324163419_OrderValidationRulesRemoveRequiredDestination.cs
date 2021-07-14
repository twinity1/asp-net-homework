using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPHomework.Migrations
{
    public partial class OrderValidationRulesRemoveRequiredDestination : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_DestinationTerms_DestinationTermId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "DestinationTermId",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_DestinationTerms_DestinationTermId",
                table: "Orders",
                column: "DestinationTermId",
                principalTable: "DestinationTerms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_DestinationTerms_DestinationTermId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "DestinationTermId",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_DestinationTerms_DestinationTermId",
                table: "Orders",
                column: "DestinationTermId",
                principalTable: "DestinationTerms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
