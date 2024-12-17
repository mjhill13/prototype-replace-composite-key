using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReplaceCompositeKey.Migrations
{
    /// <inheritdoc />
    public partial class AddIdAsPrimaryKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Entities",
                table: "Entities");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Entities",
                type: "uuid",
                nullable: false,
                defaultValueSql: "gen_random_uuid()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entities",
                table: "Entities",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Entities",
                table: "Entities");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Entities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entities",
                table: "Entities",
                columns: new[] { "Prop1", "Prop2" });
        }
    }
}
