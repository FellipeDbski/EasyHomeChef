using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EasyHomeChef.Migrations
{
    public partial class AltTabelaGI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UN",
                table: "Ingrediente",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "GeladeiraIngrediente",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UN",
                table: "Ingrediente");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "GeladeiraIngrediente");
        }
    }
}
