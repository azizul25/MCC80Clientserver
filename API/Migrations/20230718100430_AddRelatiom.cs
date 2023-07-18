using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class AddRelatiom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_tb_tr_bookings_employeeguid",
                table: "tb_tr_bookings",
                column: "employeeguid");

            migrationBuilder.CreateIndex(
                name: "IX_tb_tr_bookings_roomguid",
                table: "tb_tr_bookings",
                column: "roomguid");

            migrationBuilder.CreateIndex(
                name: "IX_tb_tr_accountroless_accountguid",
                table: "tb_tr_accountroless",
                column: "accountguid");

            migrationBuilder.CreateIndex(
                name: "IX_tb_tr_accountroless_roleguid",
                table: "tb_tr_accountroless",
                column: "roleguid");

            migrationBuilder.CreateIndex(
                name: "IX_tb_m_educations_universiyguid",
                table: "tb_m_educations",
                column: "universiyguid");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_m_accounts_tb_m_employees_guid",
                table: "tb_m_accounts",
                column: "guid",
                principalTable: "tb_m_employees",
                principalColumn: "guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_m_educations_tb_m_employees_guid",
                table: "tb_m_educations",
                column: "guid",
                principalTable: "tb_m_employees",
                principalColumn: "guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_m_educations_tb_m_universities_universiyguid",
                table: "tb_m_educations",
                column: "universiyguid",
                principalTable: "tb_m_universities",
                principalColumn: "guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_tr_accountroless_tb_m_accounts_accountguid",
                table: "tb_tr_accountroless",
                column: "accountguid",
                principalTable: "tb_m_accounts",
                principalColumn: "guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_tr_accountroless_tb_m_roles_roleguid",
                table: "tb_tr_accountroless",
                column: "roleguid",
                principalTable: "tb_m_roles",
                principalColumn: "guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_tr_bookings_tb_m_employees_employeeguid",
                table: "tb_tr_bookings",
                column: "employeeguid",
                principalTable: "tb_m_employees",
                principalColumn: "guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_tr_bookings_tb_m_rooms_roomguid",
                table: "tb_tr_bookings",
                column: "roomguid",
                principalTable: "tb_m_rooms",
                principalColumn: "guid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_m_accounts_tb_m_employees_guid",
                table: "tb_m_accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_m_educations_tb_m_employees_guid",
                table: "tb_m_educations");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_m_educations_tb_m_universities_universiyguid",
                table: "tb_m_educations");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_tr_accountroless_tb_m_accounts_accountguid",
                table: "tb_tr_accountroless");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_tr_accountroless_tb_m_roles_roleguid",
                table: "tb_tr_accountroless");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_tr_bookings_tb_m_employees_employeeguid",
                table: "tb_tr_bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_tr_bookings_tb_m_rooms_roomguid",
                table: "tb_tr_bookings");

            migrationBuilder.DropIndex(
                name: "IX_tb_tr_bookings_employeeguid",
                table: "tb_tr_bookings");

            migrationBuilder.DropIndex(
                name: "IX_tb_tr_bookings_roomguid",
                table: "tb_tr_bookings");

            migrationBuilder.DropIndex(
                name: "IX_tb_tr_accountroless_accountguid",
                table: "tb_tr_accountroless");

            migrationBuilder.DropIndex(
                name: "IX_tb_tr_accountroless_roleguid",
                table: "tb_tr_accountroless");

            migrationBuilder.DropIndex(
                name: "IX_tb_m_educations_universiyguid",
                table: "tb_m_educations");
        }
    }
}
