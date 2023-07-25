﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FileStorageContext.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pallets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Width = table.Column<decimal>(type: "NUMERIC(8,3)", precision: 8, scale: 3, nullable: false),
                    Height = table.Column<decimal>(type: "NUMERIC(8,3)", precision: 8, scale: 3, nullable: false),
                    Depth = table.Column<decimal>(type: "NUMERIC(8,3)", precision: 8, scale: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pallets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Boxes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Width = table.Column<decimal>(type: "NUMERIC(8,3)", precision: 8, scale: 3, nullable: false),
                    Height = table.Column<decimal>(type: "NUMERIC(8,3)", precision: 8, scale: 3, nullable: false),
                    Depth = table.Column<decimal>(type: "NUMERIC(8,3)", precision: 8, scale: 3, nullable: false),
                    Weight = table.Column<decimal>(type: "NUMERIC(8,3)", precision: 8, scale: 3, nullable: false),
                    PalletId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Boxes_Pallets_PalletId",
                        column: x => x.PalletId,
                        principalTable: "Pallets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Boxes_PalletId",
                table: "Boxes",
                column: "PalletId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boxes");

            migrationBuilder.DropTable(
                name: "Pallets");
        }
    }
}
