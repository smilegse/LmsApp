using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class CourseFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Created = table.Column<DateTime>(type: "DateTime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Modified = table.Column<DateTime>(type: "DateTime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CourseName = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    TrainerName = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    AverageRating = table.Column<decimal>(type: "numeric(18,2)", nullable: true, defaultValue: 0m),
                    EnrolledCount = table.Column<int>(nullable: true, defaultValue: 0),
                    RegularPrice = table.Column<decimal>(type: "numeric(18,2)", nullable: true, defaultValue: 0m),
                    DiscountPrice = table.Column<decimal>(type: "numeric(18,2)", nullable: true, defaultValue: 0m),
                    IsFree = table.Column<bool>(nullable: false, defaultValue: false),
                    Topic = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TotalDurationHour = table.Column<int>(nullable: true, defaultValue: 0),
                    TotalLectureCount = table.Column<int>(nullable: true, defaultValue: 0),
                    StudentLevel = table.Column<int>(nullable: true),
                    Language = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ViewCount = table.Column<int>(nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseName",
                table: "Courses",
                column: "CourseName");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_IsFree",
                table: "Courses",
                column: "IsFree");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Topic",
                table: "Courses",
                column: "Topic");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
