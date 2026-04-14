using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicoDent.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedGroupComboBox : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Group",
                table: "PatientBasicInfos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Group",
                value: null);

            migrationBuilder.UpdateData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Group",
                value: null);

            migrationBuilder.UpdateData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Group",
                value: null);

            migrationBuilder.UpdateData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Group",
                value: null);

            migrationBuilder.UpdateData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Group",
                value: null);

            migrationBuilder.UpdateData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Group",
                value: null);

            migrationBuilder.UpdateData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 7,
                column: "Group",
                value: null);

            migrationBuilder.UpdateData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 8,
                column: "Group",
                value: null);

            migrationBuilder.UpdateData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 9,
                column: "Group",
                value: null);

            migrationBuilder.UpdateData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 10,
                column: "Group",
                value: null);

            migrationBuilder.UpdateData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 11,
                column: "Group",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "vJqZp/pZwvFqLhBBPMkr1nG0UWI=", "dsP2hOkFasWad7Gyzk20VA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Group",
                table: "PatientBasicInfos");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "bwBar1xUGsj6mupNrz+0jHyeP7M=", "dEsX4qWCkjtnXnrNaHc4VQ==" });
        }
    }
}
