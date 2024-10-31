using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ImdexFunctional2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DbIndex",
                table: "DbIndex");

            migrationBuilder.AlterColumn<int>(
                name: "Index",
                table: "DbIndex",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "DbIndex",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "DbIndex",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "DbIndex",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "DbIndex",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbIndex",
                table: "DbIndex",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DbIndex",
                table: "DbIndex");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DbIndex");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "DbIndex");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "DbIndex");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "DbIndex");

            migrationBuilder.AlterColumn<int>(
                name: "Index",
                table: "DbIndex",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbIndex",
                table: "DbIndex",
                column: "Index");
        }
    }
}
