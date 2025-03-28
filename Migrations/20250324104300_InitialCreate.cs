using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCUP.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonalData",
                columns: table => new
                {
                    Student_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Nickname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Citizenship = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Religion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Birth_Place = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SiblingsCount = table.Column<int>(type: "int", nullable: true),
                    Birth_Order = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Present_Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Landline_Number = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Mobile_Number = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Permanent_Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    GenAvgRank = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Graduation_Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Talent_Skills = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Hobbies_Interests = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Language_Spoken = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalData", x => x.Student_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonalData");
        }
    }
}
