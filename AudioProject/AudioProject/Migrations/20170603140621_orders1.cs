using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AudioProject.Migrations
{
    public partial class orders1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderFiles_OrderItems_OrderItemsId",
                table: "OrderFiles");

            migrationBuilder.DropIndex(
                name: "IX_OrderFiles_OrderItemsId",
                table: "OrderFiles");

            migrationBuilder.DropColumn(
                name: "OrderItemsId",
                table: "OrderFiles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderItemsId",
                table: "OrderFiles",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderFiles_OrderItemsId",
                table: "OrderFiles",
                column: "OrderItemsId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderFiles_OrderItems_OrderItemsId",
                table: "OrderFiles",
                column: "OrderItemsId",
                principalTable: "OrderItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
