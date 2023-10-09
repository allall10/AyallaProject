using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectAyallaEfratNoa.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Business",
                columns: table => new
                {
                    businessId = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    businessName = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    businessCity = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    professionType = table.Column<bool>(type: "bit", nullable: true),
                    languageId = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    numWeekHours = table.Column<double>(type: "float", nullable: true),
                    seniorityBusiness = table.Column<int>(type: "int", nullable: true),
                    salaryHour = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "language1",
                columns: table => new
                {
                    languageId = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    discription = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "User1",
                columns: table => new
                {
                    userId = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    name1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    userCity = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    mail = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    age = table.Column<int>(type: "int", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    userName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    userPassword = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    professionType = table.Column<bool>(type: "bit", nullable: true),
                    expectationsSalary = table.Column<double>(type: "float", nullable: true),
                    userSeniority = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UserProperties",
                columns: table => new
                {
                    UserPropertiesId = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    userId = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    languageId = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    seniorityLanguage = table.Column<int>(type: "int", nullable: true),
                    numMonthLearn = table.Column<double>(type: "float", nullable: true),
                    diploma = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Business");

            migrationBuilder.DropTable(
                name: "language1");

            migrationBuilder.DropTable(
                name: "User1");

            migrationBuilder.DropTable(
                name: "UserProperties");
        }
    }
}
