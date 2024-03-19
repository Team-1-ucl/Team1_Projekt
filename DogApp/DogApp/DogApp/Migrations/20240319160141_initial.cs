using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DogApp.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Placements",
                columns: table => new
                {
                    PlacementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Y = table.Column<int>(type: "int", nullable: false),
                    X = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Placements", x => x.PlacementId);
                });

            migrationBuilder.CreateTable(
                name: "Rally",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    ItemListId = table.Column<int>(type: "int", nullable: false),
                    DateId = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rally", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rally_DatesCreate_DateId",
                        column: x => x.DateId,
                        principalTable: "DatesCreate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rally_ItemLists_ItemListId",
                        column: x => x.ItemListId,
                        principalTable: "ItemLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemCategory = table.Column<int>(type: "int", nullable: false),
                    PlacementId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Placements_PlacementId",
                        column: x => x.PlacementId,
                        principalTable: "Placements",
                        principalColumn: "PlacementId");
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
                table: "Items",
                columns: new[] { "Id", "Description", "Image", "ItemCategory", "Name", "PlacementId" },
                values: new object[,]
                {
                    { 1, "Description of Sign 1", "hest", 0, "Sign 1", null },
                    { 2, "Description of Sign 2", "hest", 0, "Sign 2", null },
                    { 3, "Description of Sign 3", "hest", 0, "Sign 3", null },
                    { 4, "Description of Sign 4", "hest", 0, "Sign 4", null },
                    { 5, "Description of Sign 5", "hest", 0, "Sign 5", null },
                    { 6, "Description of Extra 1", "hest", 1, "Extra 1", null },
                    { 7, "Description of Extra 2", "hest", 1, "Extra 2", null },
                    { 8, "Description of Extra 3", "hest", 1, "Extra 3", null },
                    { 9, "Description of Extra 4", "hest", 1, "Extra 4", null },
                    { 10, "Description of Extra 5", "hest", 1, "Extra 5", null }
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
                name: "IX_ItemItemLists_ItemListId",
                table: "ItemItemLists",
                column: "ItemListId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_PlacementId",
                table: "Items",
                column: "PlacementId");

            migrationBuilder.CreateIndex(
                name: "IX_Rally_DateId",
                table: "Rally",
                column: "DateId");

            migrationBuilder.CreateIndex(
                name: "IX_Rally_ItemListId",
                table: "Rally",
                column: "ItemListId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemItemLists");

            migrationBuilder.DropTable(
                name: "Rally");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "DatesCreate");

            migrationBuilder.DropTable(
                name: "ItemLists");

            migrationBuilder.DropTable(
                name: "Placements");
        }
    }
}
