using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicoDent.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedColumnsAddEditUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "4zdUv0f7FHFeKO4Cxp2X6fI7WwY=", "/p3staeaLVqMQNnW7sCGBw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "yePkysV388bwpf1OXTJb5ZMNdwQ=", "V9JWhnz8h1I9dGzJ3YTooQ==" });
        }
    }
}
