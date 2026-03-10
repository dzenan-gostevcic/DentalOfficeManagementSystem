using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicoDent.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixedmigrationsSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "PatientContacts",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.InsertData(
                table: "PatientContacts",
                columns: new[] { "Id", "City", "Country", "Email", "PatientId", "PhoneNumber", "PostalCode", "StreetName", "StreetNumber" },
                values: new object[,]
                {
                    { 2, null, null, null, 2, null, null, null, null },
                    { 3, null, null, null, 3, null, null, null, null },
                    { 4, null, null, null, 4, null, null, null, null },
                    { 5, null, null, null, 5, null, null, null, null },
                    { 6, null, null, null, 6, null, null, null, null },
                    { 7, null, null, null, 7, null, null, null, null },
                    { 8, null, null, null, 8, null, null, null, null },
                    { 9, null, null, null, 9, null, null, null, null },
                    { 10, null, null, null, 10, null, null, null, null },
                    { 11, null, null, null, 11, null, null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "bwBar1xUGsj6mupNrz+0jHyeP7M=", "dEsX4qWCkjtnXnrNaHc4VQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PatientContacts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PatientContacts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PatientContacts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PatientContacts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PatientContacts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PatientContacts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PatientContacts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PatientContacts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PatientContacts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PatientContacts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "PatientContacts",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "afLqazWAGp6E1TNsBhYdCIb74Jk=", "tiz+F67+SJs5O3AAeAsFpw==" });
        }
    }
}
