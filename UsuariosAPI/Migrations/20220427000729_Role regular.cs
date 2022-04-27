using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsuariosAPI.Migrations
{
    public partial class Roleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "9201076e-cdaa-4bfd-bdda-0e123104bd51");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99998, "e7a5d7fd-cf6e-4718-aa3a-1d6031d0baad", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6226a7b6-a6f5-415a-ae40-77f5df22c446", "AQAAAAEAACcQAAAAELTWn3pQLExzk/TNRsbH1fe76mt3EIxdgDN0AvUkTHm6yXbPQBf528RfydoPu99waQ==", "814bbc0a-b9be-4ab2-8ad3-f9dfc6dae89b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "fb9921fc-9e61-4c31-beb1-6751d79761ac");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1a0baaf-ac4c-4740-aafd-43e0a93a3316", "AQAAAAEAACcQAAAAELFm3N0chjsIlBoCMRI2O7K1Pt79u+MoQ4o8QaT0UDeVUGT5hjRuHgMD/SqqZUWCjA==", "b963bb99-35f8-4977-9050-66d7d32432f6" });
        }
    }
}
