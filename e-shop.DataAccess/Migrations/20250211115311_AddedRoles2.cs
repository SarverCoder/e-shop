using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_shop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedRoles2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_staff_role_role_role_id",
                table: "staff_role");

            migrationBuilder.DropForeignKey(
                name: "fk_staff_role_staff_accounts_staff_id",
                table: "staff_role");

            migrationBuilder.DropPrimaryKey(
                name: "pk_staff_role",
                table: "staff_role");

            migrationBuilder.DropPrimaryKey(
                name: "pk_role",
                table: "role");

            migrationBuilder.RenameTable(
                name: "staff_role",
                newName: "staff_roles");

            migrationBuilder.RenameTable(
                name: "role",
                newName: "roles");

            migrationBuilder.RenameIndex(
                name: "ix_staff_role_role_id",
                table: "staff_roles",
                newName: "ix_staff_roles_role_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_staff_roles",
                table: "staff_roles",
                columns: new[] { "staff_id", "role_id" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_roles",
                table: "roles",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_staff_roles_roles_role_id",
                table: "staff_roles",
                column: "role_id",
                principalTable: "roles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_staff_roles_staff_accounts_staff_id",
                table: "staff_roles",
                column: "staff_id",
                principalTable: "staff_accounts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_staff_roles_roles_role_id",
                table: "staff_roles");

            migrationBuilder.DropForeignKey(
                name: "fk_staff_roles_staff_accounts_staff_id",
                table: "staff_roles");

            migrationBuilder.DropPrimaryKey(
                name: "pk_staff_roles",
                table: "staff_roles");

            migrationBuilder.DropPrimaryKey(
                name: "pk_roles",
                table: "roles");

            migrationBuilder.RenameTable(
                name: "staff_roles",
                newName: "staff_role");

            migrationBuilder.RenameTable(
                name: "roles",
                newName: "role");

            migrationBuilder.RenameIndex(
                name: "ix_staff_roles_role_id",
                table: "staff_role",
                newName: "ix_staff_role_role_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_staff_role",
                table: "staff_role",
                columns: new[] { "staff_id", "role_id" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_role",
                table: "role",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_staff_role_role_role_id",
                table: "staff_role",
                column: "role_id",
                principalTable: "role",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_staff_role_staff_accounts_staff_id",
                table: "staff_role",
                column: "staff_id",
                principalTable: "staff_accounts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
