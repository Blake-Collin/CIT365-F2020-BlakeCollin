using Microsoft.EntityFrameworkCore.Migrations;


namespace ContosoUniversity.Migrations
{
    public partial class Inheritance : Migration
    {
        //protected override void Up(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.DropColumn(
        //        name: "FirstName",
        //        table: "Student");

        //    migrationBuilder.DropColumn(
        //        name: "LastName",
        //        table: "Student");

        //    migrationBuilder.DropColumn(
        //        name: "FirstName",
        //        table: "Instructor");

        //    migrationBuilder.DropColumn(
        //        name: "LastName",
        //        table: "Instructor");

        //    migrationBuilder.AlterColumn<int>(
        //        name: "ID",
        //        table: "Student",
        //        type: "int",
        //        nullable: false,
        //        oldClrType: typeof(int),
        //        oldType: "int")
        //        .OldAnnotation("SqlServer:Identity", "1, 1");

        //    migrationBuilder.AlterColumn<int>(
        //        name: "ID",
        //        table: "Instructor",
        //        type: "int",
        //        nullable: false,
        //        oldClrType: typeof(int),
        //        oldType: "int")
        //        .OldAnnotation("SqlServer:Identity", "1, 1");

        //    migrationBuilder.CreateTable(
        //        name: "Person",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
        //            FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Person", x => x.ID);
        //        });

        //    migrationBuilder.AddForeignKey(
        //        name: "FK_Instructor_Person_ID",
        //        table: "Instructor",
        //        column: "ID",
        //        principalTable: "Person",
        //        principalColumn: "ID",
        //        onDelete: ReferentialAction.Restrict);

        //    migrationBuilder.AddForeignKey(
        //        name: "FK_Student_Person_ID",
        //        table: "Student",
        //        column: "ID",
        //        principalTable: "Person",
        //        principalColumn: "ID",
        //        onDelete: ReferentialAction.Restrict);
        //}

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Student_StudentID",
                table: "Enrollment");

            migrationBuilder.DropIndex(name: "IX_Enrollment_StudentID", table: "Enrollment");

            migrationBuilder.RenameTable(name: "Instructor", newName: "Person");
            migrationBuilder.AddColumn<System.DateTime>(name: "EnrollmentDate", table: "Person", nullable: true);
            migrationBuilder.AddColumn<string>(name: "Discriminator", table: "Person", nullable: false, maxLength: 128, defaultValue: "Instructor");
            migrationBuilder.AlterColumn<System.DateTime>(name: "HireDate", table: "Person", nullable: true);
            migrationBuilder.AddColumn<int>(name: "OldId", table: "Person", nullable: true);

            // Copy existing Student data into new Person table.
            migrationBuilder.Sql("INSERT INTO dbo.Person (LastName, FirstName, HireDate, EnrollmentDate, Discriminator, OldId) SELECT LastName, FirstName, null AS HireDate, EnrollmentDate, 'Student' AS Discriminator, ID AS OldId FROM dbo.Student");
            // Fix up existing relationships to match new PK's.
            migrationBuilder.Sql("UPDATE dbo.Enrollment SET StudentId = (SELECT ID FROM dbo.Person WHERE OldId = Enrollment.StudentId AND Discriminator = 'Student')");

            // Remove temporary key
            migrationBuilder.DropColumn(name: "OldID", table: "Person");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.CreateIndex(
                 name: "IX_Enrollment_StudentID",
                 table: "Enrollment",
                 column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Person_StudentID",
                table: "Enrollment",
                column: "StudentID",
                principalTable: "Person",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Person_ID",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Person_ID",
                table: "Student");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Student",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Student",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Student",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Instructor",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Instructor",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Instructor",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
