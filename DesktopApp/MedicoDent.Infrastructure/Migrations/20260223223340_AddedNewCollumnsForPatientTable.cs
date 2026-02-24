using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicoDent.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewCollumnsForPatientTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Patients",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "CreatedDate", "DeleteDate", "HasAllergie", "IsDeleted", "IsOnBlackList", "ModifiedDate" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, null });

            migrationBuilder.InsertData(
                table: "PatientBasicInfos",
                columns: new[] { "Id", "BirthDate", "FirstName", "Gender", "IdNumber", "IdentityValue", "LastName", "MarriageStatus", "Occupation", "PatientId", "Workplace" },
                values: new object[] { 1, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guzica", null, null, null, "Doe", null, null, 1, null });

            

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "an517oj65msx2zhyclEWTMl4tcE=", "yThGRQNoj0zE/ZwlznfE7Q==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Patients");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "aOsV3Ns5h1I7XPezv1MhX2d+iOI=", "P2K1kM5YduilscQqwf3CmQ==" });
        }
    }
}
