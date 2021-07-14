using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPHomework.Migrations
{
    public partial class AddDestinationTermsToDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DestinationTerm_Destinations_DestinationId",
                table: "DestinationTerm");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_DestinationTerm_DestinationTermId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DestinationTerm",
                table: "DestinationTerm");

            migrationBuilder.RenameTable(
                name: "DestinationTerm",
                newName: "DestinationTerms");

            migrationBuilder.RenameIndex(
                name: "IX_DestinationTerm_DestinationId",
                table: "DestinationTerms",
                newName: "IX_DestinationTerms_DestinationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DestinationTerms",
                table: "DestinationTerms",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DestinationTerms_Destinations_DestinationId",
                table: "DestinationTerms",
                column: "DestinationId",
                principalTable: "Destinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_DestinationTerms_Destinations_DestinationId",
                table: "DestinationTerms");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_DestinationTerms_DestinationTermId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DestinationTerms",
                table: "DestinationTerms");

            migrationBuilder.RenameTable(
                name: "DestinationTerms",
                newName: "DestinationTerm");

            migrationBuilder.RenameIndex(
                name: "IX_DestinationTerms_DestinationId",
                table: "DestinationTerm",
                newName: "IX_DestinationTerm_DestinationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DestinationTerm",
                table: "DestinationTerm",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DestinationTerm_Destinations_DestinationId",
                table: "DestinationTerm",
                column: "DestinationId",
                principalTable: "Destinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_DestinationTerm_DestinationTermId",
                table: "Orders",
                column: "DestinationTermId",
                principalTable: "DestinationTerm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
