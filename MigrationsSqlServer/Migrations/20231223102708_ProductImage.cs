using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MigrationsSqlServer.Migrations
{
    /// <inheritdoc />
    public partial class ProductImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImage_AspNetUsers_UserId",
                table: "ProductImage");

            migrationBuilder.DropIndex(
                name: "IX_ProductImage_UserId",
                table: "ProductImage");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "ProductImage");

            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "ProductImage");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ProductImage");

            migrationBuilder.AddColumn<Guid>(
                name: "ManagerId",
                table: "UserAddresses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ManagerId1",
                table: "UserAddresses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserAddresses_ManagerId",
                table: "UserAddresses",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddresses_ManagerId1",
                table: "UserAddresses",
                column: "ManagerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddresses_AspNetUsers_ManagerId",
                table: "UserAddresses",
                column: "ManagerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddresses_AspNetUsers_ManagerId1",
                table: "UserAddresses",
                column: "ManagerId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAddresses_AspNetUsers_ManagerId",
                table: "UserAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAddresses_AspNetUsers_ManagerId1",
                table: "UserAddresses");

            migrationBuilder.DropIndex(
                name: "IX_UserAddresses_ManagerId",
                table: "UserAddresses");

            migrationBuilder.DropIndex(
                name: "IX_UserAddresses_ManagerId1",
                table: "UserAddresses");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "UserAddresses");

            migrationBuilder.DropColumn(
                name: "ManagerId1",
                table: "UserAddresses");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "ProductImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "ProductImage",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "ProductImage",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_UserId",
                table: "ProductImage",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImage_AspNetUsers_UserId",
                table: "ProductImage",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
