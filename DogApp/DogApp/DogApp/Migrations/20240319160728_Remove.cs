using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DogApp.Migrations
{
    /// <inheritdoc />
    public partial class Remove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rally_DatesCreate_DateId",
                table: "Rally");

            migrationBuilder.DropForeignKey(
                name: "FK_Rally_ItemLists_ItemListId",
                table: "Rally");

            migrationBuilder.DropTable(
                name: "DatesCreate");

            migrationBuilder.DropTable(
                name: "ItemItemLists");

            migrationBuilder.DropTable(
                name: "ItemLists");

            migrationBuilder.DropIndex(
                name: "IX_Rally_DateId",
                table: "Rally");

            migrationBuilder.DropIndex(
                name: "IX_Rally_ItemListId",
                table: "Rally");

            migrationBuilder.DropColumn(
                name: "DateId",
                table: "Rally");

            migrationBuilder.DropColumn(
                name: "ItemListId",
                table: "Rally");

            migrationBuilder.CreateTable(
                name: "ItemRally",
                columns: table => new
                {
                    ItemsId = table.Column<int>(type: "int", nullable: false),
                    RallyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemRally", x => new { x.ItemsId, x.RallyId });
                    table.ForeignKey(
                        name: "FK_ItemRally_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemRally_Rally_RallyId",
                        column: x => x.RallyId,
                        principalTable: "Rally",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemRally_RallyId",
                table: "ItemRally",
                column: "RallyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemRally");

            migrationBuilder.AddColumn<int>(
                name: "DateId",
                table: "Rally",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemListId",
                table: "Rally",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DatesCreate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatesCreate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemItemLists",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ItemListId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemItemLists", x => new { x.ItemId, x.ItemListId });
                    table.ForeignKey(
                        name: "FK_ItemItemLists_ItemLists_ItemListId",
                        column: x => x.ItemListId,
                        principalTable: "ItemLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemItemLists_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "ItemLists",
                columns: new[] { "Id", "Number" },
                values: new object[,]
                {
                    { 1, 0 },
                    { 2, 0 },
                    { 3, 0 }
                });

            migrationBuilder.InsertData(
                table: "ItemItemLists",
                columns: new[] { "ItemId", "ItemListId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 2, 4 },
                    { 5, 2, 5 },
                    { 6, 2, 6 },
                    { 7, 3, 7 },
                    { 8, 3, 8 },
                    { 9, 3, 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rally_DateId",
                table: "Rally",
                column: "DateId");

            migrationBuilder.CreateIndex(
                name: "IX_Rally_ItemListId",
                table: "Rally",
                column: "ItemListId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemItemLists_ItemListId",
                table: "ItemItemLists",
                column: "ItemListId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rally_DatesCreate_DateId",
                table: "Rally",
                column: "DateId",
                principalTable: "DatesCreate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rally_ItemLists_ItemListId",
                table: "Rally",
                column: "ItemListId",
                principalTable: "ItemLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
