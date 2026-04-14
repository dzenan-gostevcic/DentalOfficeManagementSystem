using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicoDent.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataForAllergies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdditionalNotes",
                table: "PatientBasicInfos");

            migrationBuilder.DropColumn(
                name: "AlarmStatus",
                table: "PatientBasicInfos");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Allergies");

            migrationBuilder.AddColumn<string>(
                name: "AdditionalNote",
                table: "PatientAllergies",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Dijabetes" },
                    { 2, "Ostalo" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "rmeGoutY1Bi8YzPMYbfCFfZQBiI=", "W7ciS+V/lpbHG7GjWI1mNw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "AdditionalNote",
                table: "PatientAllergies");

            migrationBuilder.AddColumn<string>(
                name: "AdditionalNotes",
                table: "PatientBasicInfos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AlarmStatus",
                table: "PatientBasicInfos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Allergies",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AdditionalNotes", "AlarmStatus" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AdditionalNotes", "AlarmStatus" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AdditionalNotes", "AlarmStatus" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AdditionalNotes", "AlarmStatus" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AdditionalNotes", "AlarmStatus" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AdditionalNotes", "AlarmStatus" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AdditionalNotes", "AlarmStatus" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AdditionalNotes", "AlarmStatus" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AdditionalNotes", "AlarmStatus" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AdditionalNotes", "AlarmStatus" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AdditionalNotes", "AlarmStatus" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "vJqZp/pZwvFqLhBBPMkr1nG0UWI=", "dsP2hOkFasWad7Gyzk20VA==" });
        }
    }
}
