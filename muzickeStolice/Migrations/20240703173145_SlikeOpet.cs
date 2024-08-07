﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace muzickeStolice.Migrations
{
    /// <inheritdoc />
    public partial class SlikeOpet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string[]>(
                name: "slikeLinkovi",
                table: "Bendovi",
                type: "text[]",
                nullable: false,
                defaultValue: new string[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "slikeLinkovi",
                table: "Bendovi");
        }
    }
}
