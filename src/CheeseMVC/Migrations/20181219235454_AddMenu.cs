using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CheeseMVC.Migrations
{
    public partial class AddMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CheeseMenu_CheeseID",
                table: "CheeseMenu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_CheeseMenu_CheeseID",
                table: "CheeseMenu",
                column: "CheeseID");
        }
    }
}
