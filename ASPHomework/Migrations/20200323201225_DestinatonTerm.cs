using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPHomework.Migrations
{
    public partial class DestinatonTerm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DestinationTermId",
                table: "Orders",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DestinationTerm",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    From = table.Column<DateTime>(nullable: false),
                    To = table.Column<DateTime>(nullable: false),
                    DestinationId1 = table.Column<int>(nullable: true),
                    DestinationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestinationTerm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DestinationTerm_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DestinationTerm_Destinations_DestinationId1",
                        column: x => x.DestinationId1,
                        principalTable: "Destinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "V období před řeckým osídlením zde žili Pelasgové (kontinentální Řecko) a Minóané (Kréta a některé ostrovy). Někdy ve 4.–3. tisíciletí před Kristem do Řecka");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "tálie, celým názvem Italská republika (italsky Italia a Repubblica Italiana) je stát ležící v ... K Itálii patří dva velké ostrovy ve Středozemním moři: Sardinie a Sicílie");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "S 1,4 miliardy obyvatel je Čína nejlidnatější zemí světa, rozloha 9,6 milionu km² ji činí čtvrtým největším státem. Díky své rychle rostoucí ekonomice a vojenské síle");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DestinationTermId",
                table: "Orders",
                column: "DestinationTermId");

            migrationBuilder.CreateIndex(
                name: "IX_DestinationTerm_DestinationId",
                table: "DestinationTerm",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_DestinationTerm_DestinationId1",
                table: "DestinationTerm",
                column: "DestinationId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_DestinationTerm_DestinationTermId",
                table: "Orders",
                column: "DestinationTermId",
                principalTable: "DestinationTerm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_DestinationTerm_DestinationTermId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "DestinationTerm");

            migrationBuilder.DropIndex(
                name: "IX_Orders_DestinationTermId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DestinationTermId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "V období před řeckým osídlením zde žili Pelasgové (kontinentální Řecko) a Minóané (Kréta a některé ostrovy). Někdy ve 4.–3. tisíciletí před Kristem do Řecka ...");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "tálie, celým názvem Italská republika (italsky Italia a Repubblica Italiana) je stát ležící v ... K Itálii patří dva velké ostrovy ve Středozemním moři: Sardinie a Sicílie.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "S 1,4 miliardy obyvatel je Čína nejlidnatější zemí světa, rozloha 9,6 milionu km² ji činí čtvrtým největším státem. Díky své rychle rostoucí ekonomice a vojenské síle  ...");
        }
    }
}
