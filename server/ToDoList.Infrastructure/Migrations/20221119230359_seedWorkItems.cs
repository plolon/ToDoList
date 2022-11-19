using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToDoList.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedWorkItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WorkItems",
                columns: new[] { "Id", "CreatedOn", "Description", "ModifiedOn", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WorkItem 1 Description text", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WorkItem 1" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WorkItem 2" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WorkItem 3 Description longer text lorem ipsum", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WorkItem 3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WorkItems",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
