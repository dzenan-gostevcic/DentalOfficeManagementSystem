using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicoDent.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewColumnsForPatienBasinInfoTableAndSmallFixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Allergies_Patients_PatientId",
                table: "Allergies");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPatientGroups_PatientGroups_PatientGroupId",
                table: "PatientPatientGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPatientGroups_Patients_PatientId1",
                table: "PatientPatientGroups");

            migrationBuilder.DropIndex(
                name: "IX_PatientPatientGroups_PatientGroupId",
                table: "PatientPatientGroups");

            migrationBuilder.DropIndex(
                name: "IX_PatientPatientGroups_PatientId1",
                table: "PatientPatientGroups");

            migrationBuilder.DropIndex(
                name: "IX_Allergies_PatientId",
                table: "Allergies");

            migrationBuilder.DropColumn(
                name: "PatientGroupId",
                table: "PatientPatientGroups");

            migrationBuilder.DropColumn(
                name: "PatientId1",
                table: "PatientPatientGroups");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Allergies");

            migrationBuilder.AddColumn<string>(
                name: "AdditionalHealthInsuranceNumber",
                table: "PatientBasicInfos",
                type: "TEXT",
                nullable: true);

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
                name: "BirthPlace",
                table: "PatientBasicInfos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HealthInsuranceNumber",
                table: "PatientBasicInfos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Parent",
                table: "PatientBasicInfos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SocialSecurityNumber",
                table: "PatientBasicInfos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AdditionalHealthInsuranceNumber", "AdditionalNotes", "AlarmStatus", "BirthPlace", "HealthInsuranceNumber", "Parent", "PatientId", "SocialSecurityNumber" },
                values: new object[] { null, null, null, null, null, null, 1, null });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "CreatedDate", "DeleteDate", "HasAllergie", "IsBlackListed", "IsDeleted", "ModifiedDate" },
                values: new object[,]
                {
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, null },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, null },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, null },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, null },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, null },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, null },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "N6/xo0zAawOiCOacQh1OvX6MILw=", "kHcLVXagMLDts3FXn/3vbg==" });

            migrationBuilder.InsertData(
                table: "PatientBasicInfos",
                columns: new[] { "Id", "AdditionalHealthInsuranceNumber", "AdditionalNotes", "AlarmStatus", "BirthDate", "BirthPlace", "FirstName", "Gender", "HealthInsuranceNumber", "IdNumber", "IdentityValue", "LastName", "MarriageStatus", "Occupation", "Parent", "PatientId", "SocialSecurityNumber", "Workplace" },
                values: new object[,]
                {
                    { 2, null, null, null, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John", null, null, null, null, "Doe", null, null, null, 2, null, null },
                    { 3, null, null, null, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jane", null, null, null, null, "Doe", null, null, null, 3, null, null },
                    { 4, null, null, null, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jack", null, null, null, null, "Doe", null, null, null, 4, null, null },
                    { 5, null, null, null, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jill", null, null, null, null, "Doe", null, null, null, 5, null, null },
                    { 6, null, null, null, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "James", null, null, null, null, "Doe", null, null, null, 6, null, null },
                    { 7, null, null, null, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jenny", null, null, null, null, "Doe", null, null, null, 7, null, null },
                    { 8, null, null, null, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Joe", null, null, null, null, "Doe", null, null, null, 8, null, null },
                    { 9, null, null, null, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jessica", null, null, null, null, "Doe", null, null, null, 9, null, null },
                    { 10, null, null, null, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jeremy", null, null, null, null, "Doe", null, null, null, 10, null, null },
                    { 11, null, null, null, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Julia", null, null, null, null, "Doe", null, null, null, 11, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PatientBasicInfos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DropColumn(
                name: "AdditionalHealthInsuranceNumber",
                table: "PatientBasicInfos");

            migrationBuilder.DropColumn(
                name: "AdditionalNotes",
                table: "PatientBasicInfos");

            migrationBuilder.DropColumn(
                name: "AlarmStatus",
                table: "PatientBasicInfos");

            migrationBuilder.DropColumn(
                name: "BirthPlace",
                table: "PatientBasicInfos");

            migrationBuilder.DropColumn(
                name: "HealthInsuranceNumber",
                table: "PatientBasicInfos");

            migrationBuilder.DropColumn(
                name: "Parent",
                table: "PatientBasicInfos");

            migrationBuilder.DropColumn(
                name: "SocialSecurityNumber",
                table: "PatientBasicInfos");

            migrationBuilder.AddColumn<int>(
                name: "PatientGroupId",
                table: "PatientPatientGroups",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientId1",
                table: "PatientPatientGroups",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Allergies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_PatientPatientGroups_PatientGroupId",
                table: "PatientPatientGroups",
                column: "PatientGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientPatientGroups_PatientId1",
                table: "PatientPatientGroups",
                column: "PatientId1");

            migrationBuilder.CreateIndex(
                name: "IX_Allergies_PatientId",
                table: "Allergies",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Allergies_Patients_PatientId",
                table: "Allergies",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPatientGroups_PatientGroups_PatientGroupId",
                table: "PatientPatientGroups",
                column: "PatientGroupId",
                principalTable: "PatientGroups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPatientGroups_Patients_PatientId1",
                table: "PatientPatientGroups",
                column: "PatientId1",
                principalTable: "Patients",
                principalColumn: "Id");
        }
    }
}
