using Microsoft.EntityFrameworkCore.Migrations;

namespace WM.Infrastructure.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    AddressLine = table.Column<string>(maxLength: 100, nullable: true),
                    County = table.Column<string>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    ZipPostalCode = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    AddressLine = table.Column<string>(maxLength: 100, nullable: true),
                    County = table.Column<string>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    ZipPostalCode = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ManufacturerId = table.Column<int>(nullable: true),
                    SupplierId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Supplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Drink" },
                    { 2, null, "Food" },
                    { 3, null, "Cofee" },
                    { 4, null, "Beer draft" },
                    { 5, null, "Beer bottle" },
                    { 6, null, "Juice" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturer",
                columns: new[] { "Id", "AddressLine", "City", "County", "Description", "Name", "Phone", "ZipPostalCode" },
                values: new object[,]
                {
                    { 1, null, "Apatin", null, null, "Proizvodjac 1", null, null },
                    { 2, null, "Beograd", null, null, "Proizvodjac 2", null, null },
                    { 3, null, "Beograd", null, null, "Proizvodjac 3", null, null }
                });

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "Id", "AddressLine", "City", "County", "Description", "Name", "Phone", "ZipPostalCode" },
                values: new object[,]
                {
                    { 1, null, null, null, null, "Supplier 1", null, null },
                    { 2, null, null, null, null, "Supplier 2", null, null }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "ManufacturerId", "Name", "Price", "SupplierId" },
                values: new object[,]
                {
                    { 2, 4, null, 1, "Jelen toceno 0.5", 130m, null },
                    { 3, 3, null, 2, "Domaca kafa", 110m, null },
                    { 4, 3, null, 2, "Cappuccino", 130m, null },
                    { 5, 5, null, 3, "Budweiser 0.5", 140m, null },
                    { 6, 5, null, 3, "Tuborg 0.5", 140m, null },
                    { 7, 6, null, 3, "Breskva 0.2", 140m, null },
                    { 8, 6, null, 3, "Sumsko voce 0.2", 140m, null },
                    { 1, 4, null, 1, "Nik toceno 0.5", 130m, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ManufacturerId",
                table: "Product",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SupplierId",
                table: "Product",
                column: "SupplierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Manufacturer");

            migrationBuilder.DropTable(
                name: "Supplier");
        }
    }
}
