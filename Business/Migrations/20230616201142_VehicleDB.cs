using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Business.Migrations
{
    public partial class VehicleDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxSpeed = table.Column<int>(type: "int", nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: true),
                    HeadlightsStatus = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Discriminator", "MaxSpeed", "VehicleColor", "VehicleType" },
                values: new object[,]
                {
                    { 5, "Boat", 100, "blue", "Boat" },
                    { 6, "Boat", 123, "red", "Boat" },
                    { 7, "Boat", 142, "black", "Boat" },
                    { 8, "Boat", 154, "white", "Boat" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Capacity", "Discriminator", "VehicleColor", "VehicleType" },
                values: new object[,]
                {
                    { 9, 36, "Bus", "red", "Bus" },
                    { 10, 26, "Bus", "white", "Bus" },
                    { 11, 12, "Bus", "black", "Bus" },
                    { 12, 19, "Bus", "blue", "Bus" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Discriminator", "HeadlightsStatus", "VehicleColor", "VehicleType" },
                values: new object[,]
                {
                    { 1, "Car", true, "blue", "Car" },
                    { 2, "Car", true, "red", "Car" },
                    { 3, "Car", true, "white", "Car" },
                    { 4, "Car", true, "black", "Car" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
