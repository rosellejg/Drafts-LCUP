using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCUP.Migrations
{
    /// <inheritdoc />
    public partial class reportcard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Report_Card",
                columns: table => new
                {
                    Student_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Academic_Year_Id = table.Column<int>(type: "int", nullable: false),
                    Grading_Period_Id = table.Column<int>(type: "int", nullable: false),
                    LRN = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Subject_Id = table.Column<int>(type: "int", nullable: false),
                    Academic_Grade = table.Column<int>(type: "int", nullable: false),
                    Subject_Conduct_Grade = table.Column<int>(type: "int", nullable: false),
                    Average_Grade = table.Column<int>(type: "int", nullable: false),
                    Homeroom_Grade_Id = table.Column<int>(type: "int", nullable: false),
                    Club_Grade_Id = table.Column<int>(type: "int", nullable: false),
                    Mandarin_Grade_Id = table.Column<int>(type: "int", nullable: false),
                    CXLC_Id = table.Column<int>(type: "int", nullable: false),
                    Conduct_Average = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report_Card", x => x.Student_Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Report_Card");
        }
    }
}
