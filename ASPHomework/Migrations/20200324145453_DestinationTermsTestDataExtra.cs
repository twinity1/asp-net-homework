using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPHomework.Migrations
{
    public partial class DestinationTermsTestDataExtra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "Id", "Capacity", "Description", "Title" },
                values: new object[] { 2, 20, "Itálie, celým názvem Italská republika (italsky Italia a Repubblica Italiana) je stát ležící v ... K Itálii patří dva velké ostrovy ve Středozemním moři: Sardinie a Sicílie", "Itálie" });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "Id", "Capacity", "Description", "Title" },
                values: new object[] { 3, 5, "S 1,4 miliardy obyvatel je Čína nejlidnatější zemí světa, rozloha 9,6 milionu km² ji činí čtvrtým největším státem. Díky své rychle rostoucí ekonomice a vojenské síle", "Čína" });

            migrationBuilder.InsertData(
                table: "DestinationTerm",
                columns: new[] { "Id", "DestinationId", "From", "To" },
                values: new object[,]
                {
                    { 12, 2, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 3, new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 3, new DateTime(2020, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 3, new DateTime(2020, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 3, new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 3, new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 3, new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 3, new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 3, new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 3, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 2, new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 2, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 2, new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 2, new DateTime(2020, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 2, new DateTime(2020, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 2, new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 2, new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 2, new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 2, new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 2, new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 3, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 3, new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DestinationTerm",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DestinationTerm",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "DestinationTerm",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "DestinationTerm",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "DestinationTerm",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "DestinationTerm",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "DestinationTerm",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "DestinationTerm",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "DestinationTerm",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "DestinationTerm",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "DestinationTerm",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "DestinationTerm",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "DestinationTerm",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "DestinationTerm",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "DestinationTerm",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "DestinationTerm",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "DestinationTerm",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "DestinationTerm",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "DestinationTerm",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "DestinationTerm",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "DestinationTerm",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "DestinationTerm",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
