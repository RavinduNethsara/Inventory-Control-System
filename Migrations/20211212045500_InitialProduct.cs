using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryControlSystem.Migrations
{
    public partial class InitialProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    productID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    productCategory = table.Column<int>(type: "int", nullable: false),
                    productDescription = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    productPrice = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    productQuantity = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.productID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
