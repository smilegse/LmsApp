using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class CourseInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Modified = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    TrainerName = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    AverageRating = table.Column<double>(nullable: false),
                    EnrolledCount = table.Column<int>(nullable: false),
                    RegularPrice = table.Column<double>(nullable: false),
                    DiscountPrice = table.Column<double>(nullable: false),
                    IsFree = table.Column<bool>(nullable: false),
                    Topic = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TotalDurationHour = table.Column<int>(nullable: false),
                    TotalLectureCount = table.Column<int>(nullable: false),
                    StudentLevel = table.Column<int>(nullable: false),
                    Language = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ViewCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_IsFree",
                table: "Courses",
                column: "IsFree");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Name",
                table: "Courses",
                column: "Name");

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
