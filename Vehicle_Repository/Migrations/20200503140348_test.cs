using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vehicle_Repository.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ParkingSlotNumber = table.Column<int>(nullable: false),
                    VehicleNumber = table.Column<int>(nullable: false),
                    EntryTime = table.Column<DateTime>(nullable: false),
                    ChargePerHour = table.Column<double>(nullable: false),
                    ParkingType = table.Column<string>(nullable: true),
                    VehicleType = table.Column<string>(nullable: true),
                    drivertype = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
