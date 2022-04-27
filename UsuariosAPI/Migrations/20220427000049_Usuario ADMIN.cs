using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsuariosAPI.Migrations
{
    public partial class UsuarioADMIN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99999, "fb9921fc-9e61-4c31-beb1-6751d79761ac", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 99999, 0, "b1a0baaf-ac4c-4740-aafd-43e0a93a3316", "admin@admin.com", true, false, null, "ADMIN@ADMIN.com", "ADMIN", "AQAAAAEAACcQAAAAELFm3N0chjsIlBoCMRI2O7K1Pt79u+MoQ4o8QaT0UDeVUGT5hjRuHgMD/SqqZUWCjA==", null, false, "b963bb99-35f8-4977-9050-66d7d32432f6", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 99999, 99999 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 99999, 99999 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999);
        }
    }
}
