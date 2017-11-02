using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Week8Demo.Migrations
{
    public partial class addedlist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TaskListID",
                table: "TodoItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TodoItems_TaskListID",
                table: "TodoItems",
                column: "TaskListID");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItems_TaskList_TaskListID",
                table: "TodoItems",
                column: "TaskListID",
                principalTable: "TaskList",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoItems_TaskList_TaskListID",
                table: "TodoItems");

            migrationBuilder.DropIndex(
                name: "IX_TodoItems_TaskListID",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "TaskListID",
                table: "TodoItems");
        }
    }
}
