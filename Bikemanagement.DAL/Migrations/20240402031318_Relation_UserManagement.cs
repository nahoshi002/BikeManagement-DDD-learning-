using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BikeManagement.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Relation_UserManagement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Complain_Replys_Complains_Complain_Id1",
                table: "Complain_Replys");

            migrationBuilder.DropIndex(
                name: "IX_Complain_Replys_Complain_Id1",
                table: "Complain_Replys");

            migrationBuilder.DropColumn(
                name: "Complain_Id1",
                table: "Complain_Replys");

            migrationBuilder.RenameColumn(
                name: "User_Id",
                table: "Complains",
                newName: "Account_Id");

            migrationBuilder.RenameColumn(
                name: "User_Id",
                table: "Complain_Replys",
                newName: "Account_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Complains_Account_Id",
                table: "Complains",
                column: "Account_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Complain_Replys_Account_Id",
                table: "Complain_Replys",
                column: "Account_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Complain_Replys_Complain_Id",
                table: "Complain_Replys",
                column: "Complain_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Complain_Replys_Accounts_Account_Id",
                table: "Complain_Replys",
                column: "Account_Id",
                principalTable: "Accounts",
                principalColumn: "Account_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Complain_Replys_Complains_Complain_Id",
                table: "Complain_Replys",
                column: "Complain_Id",
                principalTable: "Complains",
                principalColumn: "Complain_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Complains_Accounts_Account_Id",
                table: "Complains",
                column: "Account_Id",
                principalTable: "Accounts",
                principalColumn: "Account_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Complain_Replys_Accounts_Account_Id",
                table: "Complain_Replys");

            migrationBuilder.DropForeignKey(
                name: "FK_Complain_Replys_Complains_Complain_Id",
                table: "Complain_Replys");

            migrationBuilder.DropForeignKey(
                name: "FK_Complains_Accounts_Account_Id",
                table: "Complains");

            migrationBuilder.DropIndex(
                name: "IX_Complains_Account_Id",
                table: "Complains");

            migrationBuilder.DropIndex(
                name: "IX_Complain_Replys_Account_Id",
                table: "Complain_Replys");

            migrationBuilder.DropIndex(
                name: "IX_Complain_Replys_Complain_Id",
                table: "Complain_Replys");

            migrationBuilder.RenameColumn(
                name: "Account_Id",
                table: "Complains",
                newName: "User_Id");

            migrationBuilder.RenameColumn(
                name: "Account_Id",
                table: "Complain_Replys",
                newName: "User_Id");

            migrationBuilder.AddColumn<int>(
                name: "Complain_Id1",
                table: "Complain_Replys",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Complain_Replys_Complain_Id1",
                table: "Complain_Replys",
                column: "Complain_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Complain_Replys_Complains_Complain_Id1",
                table: "Complain_Replys",
                column: "Complain_Id1",
                principalTable: "Complains",
                principalColumn: "Complain_Id");
        }
    }
}
