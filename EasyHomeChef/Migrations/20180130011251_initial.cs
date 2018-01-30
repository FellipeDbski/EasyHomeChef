using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EasyHomeChef.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Geladeira",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geladeira", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Receita",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Dificuldade = table.Column<int>(nullable: false),
                    ModoPreparo = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    TempoPreparo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receita", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tempero",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GeladeiraID = table.Column<int>(nullable: true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tempero", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tempero_Geladeira_GeladeiraID",
                        column: x => x.GeladeiraID,
                        principalTable: "Geladeira",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GeladeiraID = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Usuario_Geladeira_GeladeiraID",
                        column: x => x.GeladeiraID,
                        principalTable: "Geladeira",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ingrediente",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Categoria = table.Column<int>(nullable: false),
                    GeladeiraID = table.Column<int>(nullable: true),
                    MediaPreco = table.Column<double>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    ReceitaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingrediente", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ingrediente_Geladeira_GeladeiraID",
                        column: x => x.GeladeiraID,
                        principalTable: "Geladeira",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ingrediente_Receita_ReceitaID",
                        column: x => x.ReceitaID,
                        principalTable: "Receita",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GeladeiraTempero",
                columns: table => new
                {
                    GeladeiraID = table.Column<int>(nullable: false),
                    TemperoID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeladeiraTempero", x => new { x.GeladeiraID, x.TemperoID });
                    table.ForeignKey(
                        name: "FK_GeladeiraTempero_Geladeira_GeladeiraID",
                        column: x => x.GeladeiraID,
                        principalTable: "Geladeira",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GeladeiraTempero_Tempero_TemperoID",
                        column: x => x.TemperoID,
                        principalTable: "Tempero",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceitaTempero",
                columns: table => new
                {
                    ReceitaID = table.Column<int>(nullable: false),
                    TemperoID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceitaTempero", x => new { x.ReceitaID, x.TemperoID });
                    table.ForeignKey(
                        name: "FK_ReceitaTempero_Receita_ReceitaID",
                        column: x => x.ReceitaID,
                        principalTable: "Receita",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceitaTempero_Tempero_TemperoID",
                        column: x => x.TemperoID,
                        principalTable: "Tempero",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GeladeiraIngrediente",
                columns: table => new
                {
                    GeladeiraID = table.Column<int>(nullable: false),
                    IngredienteID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeladeiraIngrediente", x => new { x.GeladeiraID, x.IngredienteID });
                    table.ForeignKey(
                        name: "FK_GeladeiraIngrediente_Geladeira_GeladeiraID",
                        column: x => x.GeladeiraID,
                        principalTable: "Geladeira",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GeladeiraIngrediente_Ingrediente_IngredienteID",
                        column: x => x.IngredienteID,
                        principalTable: "Ingrediente",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceitaIngrediente",
                columns: table => new
                {
                    ReceitaID = table.Column<int>(nullable: false),
                    IngredienteID = table.Column<int>(nullable: false),
                    UnidadeMedida = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceitaIngrediente", x => new { x.ReceitaID, x.IngredienteID });
                    table.ForeignKey(
                        name: "FK_ReceitaIngrediente_Ingrediente_IngredienteID",
                        column: x => x.IngredienteID,
                        principalTable: "Ingrediente",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceitaIngrediente_Receita_ReceitaID",
                        column: x => x.ReceitaID,
                        principalTable: "Receita",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GeladeiraIngrediente_IngredienteID",
                table: "GeladeiraIngrediente",
                column: "IngredienteID");

            migrationBuilder.CreateIndex(
                name: "IX_GeladeiraTempero_TemperoID",
                table: "GeladeiraTempero",
                column: "TemperoID");

            migrationBuilder.CreateIndex(
                name: "IX_Ingrediente_GeladeiraID",
                table: "Ingrediente",
                column: "GeladeiraID");

            migrationBuilder.CreateIndex(
                name: "IX_Ingrediente_ReceitaID",
                table: "Ingrediente",
                column: "ReceitaID");

            migrationBuilder.CreateIndex(
                name: "IX_ReceitaIngrediente_IngredienteID",
                table: "ReceitaIngrediente",
                column: "IngredienteID");

            migrationBuilder.CreateIndex(
                name: "IX_ReceitaTempero_TemperoID",
                table: "ReceitaTempero",
                column: "TemperoID");

            migrationBuilder.CreateIndex(
                name: "IX_Tempero_GeladeiraID",
                table: "Tempero",
                column: "GeladeiraID");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_GeladeiraID",
                table: "Usuario",
                column: "GeladeiraID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeladeiraIngrediente");

            migrationBuilder.DropTable(
                name: "GeladeiraTempero");

            migrationBuilder.DropTable(
                name: "ReceitaIngrediente");

            migrationBuilder.DropTable(
                name: "ReceitaTempero");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Ingrediente");

            migrationBuilder.DropTable(
                name: "Tempero");

            migrationBuilder.DropTable(
                name: "Receita");

            migrationBuilder.DropTable(
                name: "Geladeira");
        }
    }
}
