using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorClinicAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Experience = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "Id", "Experience", "Name", "Specialization" },
                values: new object[] { 101, 2.0, "Arvind", "MBBS" });

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "Id", "Experience", "Name", "Specialization" },
                values: new object[] { 102, 3.0, "Sunil", "Surgen" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctor");
        }
    }
}
