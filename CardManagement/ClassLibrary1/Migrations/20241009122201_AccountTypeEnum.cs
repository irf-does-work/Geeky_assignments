using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardManagementModels.Migrations
{
    /// <inheritdoc />
    public partial class AccountTypeEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "accountType",
                table: "Account",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "accountType",
                table: "Account");
        }
    }
}
