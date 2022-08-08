using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace precip.Migrations
{
    public partial class inita : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "precipitation",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amountinches = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WeatherType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCOde = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_precipitation", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "precipitation");
        }
    }
}
