using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BikeManagement.DAL.Migrations
{
    /// <inheritdoc />
    public partial class NotificationAccountRel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Accounts_AccountReceiverAccount_Id",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Accounts_AccountSenderAccount_Id",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_AccountReceiverAccount_Id",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_AccountSenderAccount_Id",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "AccountReceiverAccount_Id",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "AccountSenderAccount_Id",
                table: "Notifications");

            migrationBuilder.AddColumn<int>(
                name: "Sender_Id",
                table: "Notifications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_Sender_Id",
                table: "Notifications",
                column: "Sender_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Accounts_Sender_Id",
                table: "Notifications",
                column: "Sender_Id",
                principalTable: "Accounts",
                principalColumn: "Account_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Accounts_Sender_Id",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_Sender_Id",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "Sender_Id",
                table: "Notifications");

            migrationBuilder.AddColumn<int>(
                name: "AccountReceiverAccount_Id",
                table: "Notifications",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountSenderAccount_Id",
                table: "Notifications",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_AccountReceiverAccount_Id",
                table: "Notifications",
                column: "AccountReceiverAccount_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_AccountSenderAccount_Id",
                table: "Notifications",
                column: "AccountSenderAccount_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Accounts_AccountReceiverAccount_Id",
                table: "Notifications",
                column: "AccountReceiverAccount_Id",
                principalTable: "Accounts",
                principalColumn: "Account_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Accounts_AccountSenderAccount_Id",
                table: "Notifications",
                column: "AccountSenderAccount_Id",
                principalTable: "Accounts",
                principalColumn: "Account_Id");
        }
    }
}
