using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVClast.Migrations
{
    /// <inheritdoc />
    public partial class IntialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DeptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DeptId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudenteName = table.Column<string>(name: "Student eName", type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DeptId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DeptId", "DeptName" },
                values: new object[,]
                {
                    { 1, "Math" },
                    { 2, "Science" },
                    { 3, "Arabic" },
                    { 4, "English" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "Age", "DepartmentId", "Email", "Student eName", "Password" },
                values: new object[,]
                {
                    { 1, "Ismaillia", 20, 1, "Ahmed.1222@example.com", "Ahmed Abdallah", "Ahmed1111" },
                    { 2, "Ismaillia", 16, 2, "Ali.1222@example.com", "Ali Ahmed", "Ali11112" },
                    { 3, "Ismaillia", 16, 3, "Maya.1222@example.com", "Maya", "Maya111113" },
                    { 4, "Ismaillia", 15, 4, "Omar.1222@example.com", "Omar", "Omar111123" },
                    { 5, "Ismaillia", 13, 1, "Abdallah.1222@example.com", "Abdallah", "Abdallah111112" },
                    { 6, "Ismaillia", 16, 2, "Hatem.1222@example.com", "Hatem", "Hatem111121" },
                    { 7, "Ismaillia", 19, 3, "Wael.1222@example.com", "Wael", "Wael1111" },
                    { 8, "Ismaillia", 18, 4, "Laila1222@example.com", "Laila", "Laila1111" },
                    { 9, "Ismaillia", 16, 1, "Fathy.1222@example.com", "Fathy", "Fathy1111" },
                    { 10, "Ismaillia", 15, 2, "Osama.1222@example.com", "Osama", "OSama1111" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentId",
                table: "Students",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
