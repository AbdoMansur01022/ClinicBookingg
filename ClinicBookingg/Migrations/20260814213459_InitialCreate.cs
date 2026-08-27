using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicBookingg.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearsOfExperience = table.Column<int>(type: "int", nullable: false),
                    IsAcceptingPatients = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Bio", "IsAcceptingPatients", "Name", "Specialty", "YearsOfExperience" },
                values: new object[,]
                {
                    { 1, "Expert cardiologist.", true, "Dr. Amina Farid", "Cardiology", 15 },
                    { 2, "Cosmetic & medical dermatology.", false, "Dr. Youssef Hany", "Dermatology", 8 },
                    { 3, "Pediatrician caring for children.", true, "Dr. Layla Mahmoud", "Pediatrics", 12 },
                    { 4, "Senior orthopedic surgeon.", true, "Dr. Omar Nasser", "Orthopedics", 20 },
                    { 5, "General and cosmetic dentistry.", true, "Dr. Salma Ibrahim", "Dentistry", 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctors");
        }
    }
}
