using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    idProduct = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nameProduct = table.Column<string>(maxLength: 50, nullable: true),
                    priceProduct = table.Column<float>(nullable: false),
                    categoryProduct = table.Column<string>(maxLength: 50, nullable: true),
                    imageProdusct = table.Column<string>(nullable: true),
                    previewProduct = table.Column<string>(maxLength: 100, nullable: true),
                    detailProduct = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.idProduct);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    idUser = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    loginUser = table.Column<string>(maxLength: 25, nullable: true),
                    passwordUser = table.Column<string>(maxLength: 50, nullable: true),
                    lastNameUser = table.Column<string>(maxLength: 25, nullable: true),
                    firstNameUser = table.Column<string>(maxLength: 25, nullable: true),
                    secondNameUser = table.Column<string>(maxLength: 25, nullable: true),
                    mailUser = table.Column<string>(maxLength: 50, nullable: true),
                    roleUser = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.idUser);
                });

            migrationBuilder.CreateTable(
                name: "Receipt",
                columns: table => new
                {
                    idReceipt = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    datePurchase = table.Column<DateTime>(nullable: false),
                    idUser = table.Column<int>(nullable: false),
                    idProduct = table.Column<int>(nullable: false),
                    UseridUser = table.Column<int>(nullable: true),
                    ProductidProduct = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipt", x => x.idReceipt);
                    table.ForeignKey(
                        name: "FK_Receipt_Product_ProductidProduct",
                        column: x => x.ProductidProduct,
                        principalTable: "Product",
                        principalColumn: "idProduct",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Receipt_User_UseridUser",
                        column: x => x.UseridUser,
                        principalTable: "User",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_ProductidProduct",
                table: "Receipt",
                column: "ProductidProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_UseridUser",
                table: "Receipt",
                column: "UseridUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receipt");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
