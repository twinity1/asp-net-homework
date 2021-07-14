using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPHomework.Migrations
{
    public partial class destination_test_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "Id", "Capacity", "Description", "Title" },
                values: new object[] { 1, 14, "V období před řeckým osídlením zde žili Pelasgové (kontinentální Řecko) a Minóané (Kréta a některé ostrovy). Někdy ve 4.–3. tisíciletí před Kristem do Řecka ...", "Řecko" });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "Id", "Capacity", "Description", "Title" },
                values: new object[] { 2, 20, "tálie, celým názvem Italská republika (italsky Italia a Repubblica Italiana) je stát ležící v ... K Itálii patří dva velké ostrovy ve Středozemním moři: Sardinie a Sicílie.", "Itálie" });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "Id", "Capacity", "Description", "Title" },
                values: new object[] { 3, 5, "S 1,4 miliardy obyvatel je Čína nejlidnatější zemí světa, rozloha 9,6 milionu km² ji činí čtvrtým největším státem. Díky své rychle rostoucí ekonomice a vojenské síle  ...", "Čína" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1);

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
