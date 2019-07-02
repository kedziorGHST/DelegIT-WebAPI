using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DelegIT_webapi.Migrations
{
    public partial class Initialandmodelsmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    model = table.Column<string>(type: "varchar(30)", nullable: false),
                    company = table.Column<string>(type: "varchar(30)", nullable: false),
                    year = table.Column<int>(nullable: false),
                    type = table.Column<string>(type: "varchar(15)", nullable: false),
                    plates = table.Column<string>(type: "varchar(10)", nullable: false),
                    colour = table.Column<string>(type: "varchar(20)", nullable: false),
                    horsePower = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fullCompanyName = table.Column<string>(nullable: true),
                    shortCompanyName = table.Column<string>(nullable: true),
                    nip = table.Column<string>(nullable: true),
                    managerFName = table.Column<string>(nullable: true),
                    managerLName = table.Column<string>(nullable: true),
                    street = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    postCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    companyName = table.Column<string>(nullable: true),
                    login = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    fname = table.Column<string>(nullable: true),
                    lname = table.Column<string>(nullable: true),
                    streetNumber = table.Column<string>(nullable: true),
                    position = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    postCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    type = table.Column<string>(nullable: true),
                    customerId = table.Column<int>(nullable: false),
                    from = table.Column<DateTime>(nullable: false),
                    to = table.Column<DateTime>(nullable: false),
                    range = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.id);
                    table.ForeignKey(
                        name: "FK_Contracts_Customers_customerId",
                        column: x => x.customerId,
                        principalTable: "Customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rides",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    employeeId = table.Column<int>(nullable: false),
                    carId = table.Column<int>(nullable: false),
                    whence = table.Column<string>(type: "varchar(40)", nullable: false),
                    where = table.Column<string>(type: "varchar(40)", nullable: false),
                    from = table.Column<DateTime>(nullable: false),
                    until = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rides", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rides_Cars_carId",
                        column: x => x.carId,
                        principalTable: "Cars",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rides_Employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "Employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Delegations",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    contractId = table.Column<int>(nullable: false),
                    orderDate = table.Column<DateTime>(nullable: false),
                    departureDate = table.Column<DateTime>(nullable: false),
                    arrivalDate = table.Column<DateTime>(nullable: false),
                    numberDelegation = table.Column<int>(nullable: false),
                    purpose = table.Column<string>(nullable: false),
                    transport = table.Column<string>(nullable: false),
                    country = table.Column<string>(nullable: false),
                    city = table.Column<string>(nullable: false),
                    type = table.Column<string>(nullable: false),
                    lumpSum = table.Column<int>(nullable: false),
                    driveCost = table.Column<int>(nullable: false),
                    driveSum = table.Column<int>(nullable: false),
                    diet = table.Column<int>(nullable: false),
                    accomodationCost = table.Column<int>(nullable: false),
                    otherCost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delegations", x => x.id);
                    table.ForeignKey(
                        name: "FK_Delegations_Contracts_contractId",
                        column: x => x.contractId,
                        principalTable: "Contracts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    employeeId = table.Column<int>(nullable: false),
                    contractId = table.Column<int>(nullable: false),
                    workingHours = table.Column<int>(nullable: false),
                    type = table.Column<string>(nullable: true),
                    from = table.Column<DateTime>(nullable: false),
                    to = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.id);
                    table.ForeignKey(
                        name: "FK_Visits_Contracts_contractId",
                        column: x => x.contractId,
                        principalTable: "Contracts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visits_Employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "Employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_customerId",
                table: "Contracts",
                column: "customerId");

            migrationBuilder.CreateIndex(
                name: "IX_Delegations_contractId",
                table: "Delegations",
                column: "contractId");

            migrationBuilder.CreateIndex(
                name: "IX_Rides_carId",
                table: "Rides",
                column: "carId");

            migrationBuilder.CreateIndex(
                name: "IX_Rides_employeeId",
                table: "Rides",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_contractId",
                table: "Visits",
                column: "contractId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_employeeId",
                table: "Visits",
                column: "employeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Delegations");

            migrationBuilder.DropTable(
                name: "Rides");

            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
