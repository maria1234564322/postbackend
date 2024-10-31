using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ImdexFunctional32 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DbIndex",
                table: "DbIndex");

            migrationBuilder.RenameTable(
                name: "DbIndex",
                newName: "DbIndexs");

            migrationBuilder.RenameColumn(
                name: "Districtus",
                table: "DbIndexs",
                newName: "District");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbIndexs",
                table: "DbIndexs",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DbIndexs",
                table: "DbIndexs");

            migrationBuilder.RenameTable(
                name: "DbIndexs",
                newName: "DbIndex");

            migrationBuilder.RenameColumn(
                name: "District",
                table: "DbIndex",
                newName: "Districtus");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbIndex",
                table: "DbIndex",
                column: "Id");
        }
    }
}
