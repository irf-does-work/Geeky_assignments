using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardManagementModels.Migrations
{
    /// <inheritdoc />
    public partial class Changes1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_Customer_CustomerId",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Account_AccountId",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_AccountId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Transactions",
                newName: "TxnId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customer",
                newName: "CustId");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Account",
                newName: "CustomerCustId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Account",
                newName: "AccId");

            migrationBuilder.RenameIndex(
                name: "IX_Account_CustomerId",
                table: "Account",
                newName: "IX_Account_CustomerCustId");

            migrationBuilder.AddColumn<string>(
                name: "AccountAccId",
                table: "Transactions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "transactionType",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                column: "TxnId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_AccountAccId",
                table: "Transactions",
                column: "AccountAccId");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Customer_CustomerCustId",
                table: "Account",
                column: "CustomerCustId",
                principalTable: "Customer",
                principalColumn: "CustId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Account_AccountAccId",
                table: "Transactions",
                column: "AccountAccId",
                principalTable: "Account",
                principalColumn: "AccId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_Customer_CustomerCustId",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Account_AccountAccId",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_AccountAccId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "AccountAccId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "transactionType",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "TxnId",
                table: "Transactions",
                newName: "AccountId");

            migrationBuilder.RenameColumn(
                name: "CustId",
                table: "Customer",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CustomerCustId",
                table: "Account",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "AccId",
                table: "Account",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Account_CustomerCustId",
                table: "Account",
                newName: "IX_Account_CustomerId");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Transactions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_AccountId",
                table: "Transactions",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Customer_CustomerId",
                table: "Account",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Account_AccountId",
                table: "Transactions",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
