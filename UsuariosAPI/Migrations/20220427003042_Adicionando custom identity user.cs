using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsuariosAPI.Migrations
{
    public partial class Adicionandocustomidentityuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                column: "ConcurrencyStamp",
                value: "1cb5865f-751a-4130-8f58-4ca63f50ba39");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "0ff2275b-987d-4f36-a645-a026bda374ed");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e209b63-f8f1-4faf-93fa-a9a2689eb740", "AQAAAAEAACcQAAAAEOt0TNr8GLGTXrpg+Ft8rzHWOai7pEAnhrSCmSCz91FCBket2jUvageU6XoyNM3wtA==", "22973a6e-ba28-4a5b-aa87-34cafed1abfa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                column: "ConcurrencyStamp",
                value: "e7a5d7fd-cf6e-4718-aa3a-1d6031d0baad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "9201076e-cdaa-4bfd-bdda-0e123104bd51");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6226a7b6-a6f5-415a-ae40-77f5df22c446", "AQAAAAEAACcQAAAAELTWn3pQLExzk/TNRsbH1fe76mt3EIxdgDN0AvUkTHm6yXbPQBf528RfydoPu99waQ==", "814bbc0a-b9be-4ab2-8ad3-f9dfc6dae89b" });
        }
    }
}
