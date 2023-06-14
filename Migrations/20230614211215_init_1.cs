using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace customerManagement.Migrations
{
    public partial class init_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMernisRequired = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    identityNumber = table.Column<long>(type: "bigint", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirtDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyCustomer",
                columns: table => new
                {
                    CustomersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    companiesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyCustomer", x => new { x.CustomersId, x.companiesId });
                    table.ForeignKey(
                        name: "FK_CompanyCustomer_Companies_companiesId",
                        column: x => x.companiesId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyCustomer_Customers_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CreatedDate", "IsMernisRequired", "Name" },
                values: new object[] { new Guid("e0685f1b-2142-46fd-88cf-7b949142a84e"), new DateTime(2023, 6, 15, 0, 12, 15, 296, DateTimeKind.Local).AddTicks(6143), false, "Portal Kahve" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CreatedDate", "IsMernisRequired", "Name" },
                values: new object[] { new Guid("f66306c4-e9a0-4261-87e0-deb0d5ebfbf6"), new DateTime(2023, 6, 15, 0, 12, 15, 296, DateTimeKind.Local).AddTicks(6098), true, "Starbucks" });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyCustomer_companiesId",
                table: "CompanyCustomer",
                column: "companiesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyCustomer");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
