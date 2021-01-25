using Microsoft.EntityFrameworkCore.Migrations;
//docker run -d --name ASPWebApp -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=iitpowai' -p 1433:1433 microsoft/mssql-server-linux

namespace Asp.netCoreMVCCRUD.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employess",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    EmpCode = table.Column<string>(type: "varchar(10)", nullable: true),
                    Position = table.Column<string>(type: "varchar(100)", nullable: true),
                    OfficeLocation = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employess", x => x.EmployeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employess");
        }
    }
}
