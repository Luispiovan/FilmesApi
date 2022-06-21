using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class usuarioregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 999999,
                column: "ConcurrencyStamp",
                value: "e354b296-c513-40bb-9c83-d510223ce949");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 999998, "7b5cf4cc-7855-4d0f-a03e-8c275abd061f", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 999999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff64db0d-e6ff-4cce-9c65-f64c4b907a2b", "AQAAAAEAACcQAAAAEDvoBEztP/jrHhsOoud/6ZGApjUrvp5rdZgUmrjAy+bRKEBxDwVZdh9h/nXG0AbMgg==", "10451449-87f2-4098-a629-848cfd6de590" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 999998);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 999999,
                column: "ConcurrencyStamp",
                value: "7b527954-ef41-436b-8a4a-4074ebdada27");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 999999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfb456dd-c67d-4e0b-9122-530b453df3eb", "AQAAAAEAACcQAAAAEBIcECsLr/YutmfduiuPP/9fIfSv1ehu47Cr/FhFXZNuxqb+hUrX+MWE+/Vj6MQ53A==", "d6636ec7-054c-4d41-b812-5985356a0f55" });
        }
    }
}
