using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ADHOM_Store.Data.Migrations
{
    public partial class AddStaticRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "054da5aa-473d-4d22-b029-92ba9f3badb1", "23a51e47-f53b-4e36-91fc-f785d8dbe916", "Sales", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f4a5c531-dff8-4afd-aa0d-3ecad1c9ccdf", "210a92b1-1246-43d0-88e4-f219e7d3db8f", "Admin", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f57fbccc-100e-45c1-aed2-a85b88c21458", "5fa6784b-b289-43da-921c-b7927287eebe", "Marketier", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "054da5aa-473d-4d22-b029-92ba9f3badb1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4a5c531-dff8-4afd-aa0d-3ecad1c9ccdf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f57fbccc-100e-45c1-aed2-a85b88c21458");
        }
    }
}
