using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicoDent.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Added_IsBlacklisted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsOnBlackList",
                table: "Patients",
                newName: "IsBlackListed");

            migrationBuilder.UpdateData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 1,
                column: "PatientId",
                value: 1);

            migrationBuilder.InsertData(
                table: "PatientContacts",
                columns: new[] { "Id", "City", "Country", "Email", "PatientId", "PhoneNumber", "PostalCode", "StreetName", "StreetNumber" },
                values: new object[] { 1, null, null, null, 1, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "H/ubzwoe3zIvKLLU/oF85DOBlls=", "jPi5dd+OuRIxOWEuFrbT9A==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PatientContacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "IsBlackListed",
                table: "Patients",
                newName: "IsOnBlackList");

            migrationBuilder.UpdateData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 1,
                column: "PatientId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "an517oj65msx2zhyclEWTMl4tcE=", "yThGRQNoj0zE/ZwlznfE7Q==" });
        }
    }
}
