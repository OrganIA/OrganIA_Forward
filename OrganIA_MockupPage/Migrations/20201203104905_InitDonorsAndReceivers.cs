using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrganIA_MockupPage.Migrations
{
    public partial class InitDonorsAndReceivers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Donors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfArrival = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Organ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rhesus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RhesusSign = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    HospitalFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HospitalTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    BMI = table.Column<int>(type: "int", nullable: false),
                    BloodIonogramForeignKey = table.Column<int>(type: "int", nullable: false),
                    DonorForeignKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Receivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfArrival = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrganToTransplant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rhesus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RhesusSign = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    HospitalFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HospitalTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    BMI = table.Column<int>(type: "int", nullable: false),
                    DonorKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receivers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donors");

            migrationBuilder.DropTable(
                name: "Receivers");
        }
    }
}
