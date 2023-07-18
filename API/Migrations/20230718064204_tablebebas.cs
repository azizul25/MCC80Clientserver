using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class tablebebas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Universities",
                table: "Universities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employeeds",
                table: "Employeeds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Educations",
                table: "Educations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountRoles",
                table: "AccountRoles");

            migrationBuilder.RenameTable(
                name: "Universities",
                newName: "tb_m_universities");

            migrationBuilder.RenameTable(
                name: "Rooms",
                newName: "tb_m_rooms");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "tb_m_roles");

            migrationBuilder.RenameTable(
                name: "Employeeds",
                newName: "tb_m_employees");

            migrationBuilder.RenameTable(
                name: "Educations",
                newName: "tb_m_educations");

            migrationBuilder.RenameTable(
                name: "Bookings",
                newName: "tb_tr_bookings");

            migrationBuilder.RenameTable(
                name: "Accounts",
                newName: "tb_m_accounts");

            migrationBuilder.RenameTable(
                name: "AccountRoles",
                newName: "tb_tr_accountroless");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tb_m_universities",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "tb_m_universities",
                newName: "modifieddate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "tb_m_universities",
                newName: "createddate");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "tb_m_universities",
                newName: "code");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "tb_m_universities",
                newName: "guid");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tb_m_rooms",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "tb_m_rooms",
                newName: "modifieddate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "tb_m_rooms",
                newName: "createddate");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "tb_m_rooms",
                newName: "guid");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tb_m_roles",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "tb_m_roles",
                newName: "modifieddate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "tb_m_roles",
                newName: "createddate");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "tb_m_roles",
                newName: "guid");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "tb_m_employees",
                newName: "phonenumber");

            migrationBuilder.RenameColumn(
                name: "Nik",
                table: "tb_m_employees",
                newName: "nik");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "tb_m_employees",
                newName: "modifieddate");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "tb_m_employees",
                newName: "lastname");

            migrationBuilder.RenameColumn(
                name: "HiringDate",
                table: "tb_m_employees",
                newName: "hiringdate");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "tb_m_employees",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "tb_m_employees",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "tb_m_employees",
                newName: "createddate");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "tb_m_employees",
                newName: "birthdate");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "tb_m_employees",
                newName: "guid");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "tb_m_employees",
                newName: "firsname");

            migrationBuilder.RenameIndex(
                name: "IX_Employeeds_Nik_Email_PhoneNumber",
                table: "tb_m_employees",
                newName: "IX_tb_m_employees_nik_email_phonenumber");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "tb_m_educations",
                newName: "modifieddate");

            migrationBuilder.RenameColumn(
                name: "Major",
                table: "tb_m_educations",
                newName: "major");

            migrationBuilder.RenameColumn(
                name: "GPA",
                table: "tb_m_educations",
                newName: "gpa");

            migrationBuilder.RenameColumn(
                name: "Degree",
                table: "tb_m_educations",
                newName: "degree");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "tb_m_educations",
                newName: "createddate");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "tb_m_educations",
                newName: "guid");

            migrationBuilder.RenameColumn(
                name: "UniversityGuid",
                table: "tb_m_educations",
                newName: "universiyguid");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "tb_tr_bookings",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "StarDate",
                table: "tb_tr_bookings",
                newName: "stardate");

            migrationBuilder.RenameColumn(
                name: "RoomGuid",
                table: "tb_tr_bookings",
                newName: "roomguid");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "tb_tr_bookings",
                newName: "modifieddate");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "tb_tr_bookings",
                newName: "enddate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "tb_tr_bookings",
                newName: "createddate");

            migrationBuilder.RenameColumn(
                name: "Capacity",
                table: "tb_tr_bookings",
                newName: "capacity");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "tb_tr_bookings",
                newName: "guid");

            migrationBuilder.RenameColumn(
                name: "Remarks",
                table: "tb_tr_bookings",
                newName: "remaks");

            migrationBuilder.RenameColumn(
                name: "EmployedGuid",
                table: "tb_tr_bookings",
                newName: "employeeguid");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "tb_m_accounts",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Otp",
                table: "tb_m_accounts",
                newName: "otp");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "tb_m_accounts",
                newName: "modifieddate");

            migrationBuilder.RenameColumn(
                name: "Isused",
                table: "tb_m_accounts",
                newName: "isused");

            migrationBuilder.RenameColumn(
                name: "EcpiredTime",
                table: "tb_m_accounts",
                newName: "ecpiredtime");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "tb_m_accounts",
                newName: "createddate");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "tb_m_accounts",
                newName: "guid");

            migrationBuilder.RenameColumn(
                name: "RoleGuid",
                table: "tb_tr_accountroless",
                newName: "roleguid");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "tb_tr_accountroless",
                newName: "modifieddate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "tb_tr_accountroless",
                newName: "createddate");

            migrationBuilder.RenameColumn(
                name: "AccountGuid",
                table: "tb_tr_accountroless",
                newName: "accountguid");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "tb_tr_accountroless",
                newName: "guid");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "tb_m_universities",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "code",
                table: "tb_m_universities",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "tb_m_rooms",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "tb_m_roles",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "phonenumber",
                table: "tb_m_employees",
                type: "nvarchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "nik",
                table: "tb_m_employees",
                type: "nchar(6)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "lastname",
                table: "tb_m_employees",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "tb_m_employees",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "firsname",
                table: "tb_m_employees",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "major",
                table: "tb_m_educations",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "degree",
                table: "tb_m_educations",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_m_universities",
                table: "tb_m_universities",
                column: "guid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_m_rooms",
                table: "tb_m_rooms",
                column: "guid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_m_roles",
                table: "tb_m_roles",
                column: "guid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_m_employees",
                table: "tb_m_employees",
                column: "guid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_m_educations",
                table: "tb_m_educations",
                column: "guid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_tr_bookings",
                table: "tb_tr_bookings",
                column: "guid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_m_accounts",
                table: "tb_m_accounts",
                column: "guid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_tr_accountroless",
                table: "tb_tr_accountroless",
                column: "guid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_tr_bookings",
                table: "tb_tr_bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_tr_accountroless",
                table: "tb_tr_accountroless");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_m_universities",
                table: "tb_m_universities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_m_rooms",
                table: "tb_m_rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_m_roles",
                table: "tb_m_roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_m_employees",
                table: "tb_m_employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_m_educations",
                table: "tb_m_educations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_m_accounts",
                table: "tb_m_accounts");

            migrationBuilder.RenameTable(
                name: "tb_tr_bookings",
                newName: "Bookings");

            migrationBuilder.RenameTable(
                name: "tb_tr_accountroless",
                newName: "AccountRoles");

            migrationBuilder.RenameTable(
                name: "tb_m_universities",
                newName: "Universities");

            migrationBuilder.RenameTable(
                name: "tb_m_rooms",
                newName: "Rooms");

            migrationBuilder.RenameTable(
                name: "tb_m_roles",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "tb_m_employees",
                newName: "Employeeds");

            migrationBuilder.RenameTable(
                name: "tb_m_educations",
                newName: "Educations");

            migrationBuilder.RenameTable(
                name: "tb_m_accounts",
                newName: "Accounts");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Bookings",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "stardate",
                table: "Bookings",
                newName: "StarDate");

            migrationBuilder.RenameColumn(
                name: "roomguid",
                table: "Bookings",
                newName: "RoomGuid");

            migrationBuilder.RenameColumn(
                name: "modifieddate",
                table: "Bookings",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "enddate",
                table: "Bookings",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "createddate",
                table: "Bookings",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "capacity",
                table: "Bookings",
                newName: "Capacity");

            migrationBuilder.RenameColumn(
                name: "guid",
                table: "Bookings",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "remaks",
                table: "Bookings",
                newName: "Remarks");

            migrationBuilder.RenameColumn(
                name: "employeeguid",
                table: "Bookings",
                newName: "EmployedGuid");

            migrationBuilder.RenameColumn(
                name: "roleguid",
                table: "AccountRoles",
                newName: "RoleGuid");

            migrationBuilder.RenameColumn(
                name: "modifieddate",
                table: "AccountRoles",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "createddate",
                table: "AccountRoles",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "accountguid",
                table: "AccountRoles",
                newName: "AccountGuid");

            migrationBuilder.RenameColumn(
                name: "guid",
                table: "AccountRoles",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Universities",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "modifieddate",
                table: "Universities",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "createddate",
                table: "Universities",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "code",
                table: "Universities",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "guid",
                table: "Universities",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Rooms",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "modifieddate",
                table: "Rooms",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "createddate",
                table: "Rooms",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "guid",
                table: "Rooms",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Roles",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "modifieddate",
                table: "Roles",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "createddate",
                table: "Roles",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "guid",
                table: "Roles",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "phonenumber",
                table: "Employeeds",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "nik",
                table: "Employeeds",
                newName: "Nik");

            migrationBuilder.RenameColumn(
                name: "modifieddate",
                table: "Employeeds",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "lastname",
                table: "Employeeds",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "hiringdate",
                table: "Employeeds",
                newName: "HiringDate");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "Employeeds",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Employeeds",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "createddate",
                table: "Employeeds",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "birthdate",
                table: "Employeeds",
                newName: "BirthDate");

            migrationBuilder.RenameColumn(
                name: "guid",
                table: "Employeeds",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "firsname",
                table: "Employeeds",
                newName: "FirstName");

            migrationBuilder.RenameIndex(
                name: "IX_tb_m_employees_nik_email_phonenumber",
                table: "Employeeds",
                newName: "IX_Employeeds_Nik_Email_PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "modifieddate",
                table: "Educations",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "major",
                table: "Educations",
                newName: "Major");

            migrationBuilder.RenameColumn(
                name: "gpa",
                table: "Educations",
                newName: "GPA");

            migrationBuilder.RenameColumn(
                name: "degree",
                table: "Educations",
                newName: "Degree");

            migrationBuilder.RenameColumn(
                name: "createddate",
                table: "Educations",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "guid",
                table: "Educations",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "universiyguid",
                table: "Educations",
                newName: "UniversityGuid");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Accounts",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "otp",
                table: "Accounts",
                newName: "Otp");

            migrationBuilder.RenameColumn(
                name: "modifieddate",
                table: "Accounts",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "isused",
                table: "Accounts",
                newName: "Isused");

            migrationBuilder.RenameColumn(
                name: "ecpiredtime",
                table: "Accounts",
                newName: "EcpiredTime");

            migrationBuilder.RenameColumn(
                name: "createddate",
                table: "Accounts",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "guid",
                table: "Accounts",
                newName: "Guid");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Universities",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Universities",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Employeeds",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)");

            migrationBuilder.AlterColumn<string>(
                name: "Nik",
                table: "Employeeds",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(6)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employeeds",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employeeds",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employeeds",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Major",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Degree",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings",
                column: "Guid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountRoles",
                table: "AccountRoles",
                column: "Guid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Universities",
                table: "Universities",
                column: "Guid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms",
                column: "Guid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Guid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employeeds",
                table: "Employeeds",
                column: "Guid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Educations",
                table: "Educations",
                column: "Guid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts",
                column: "Guid");
        }
    }
}
