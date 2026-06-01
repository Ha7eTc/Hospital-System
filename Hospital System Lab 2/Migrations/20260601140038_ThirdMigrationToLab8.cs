using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital_System_Lab_2.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigrationToLab8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DoctorId",
                table: "Persons",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Persons",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_DoctorId",
                table: "Persons",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Persons_DoctorId",
                table: "Persons",
                column: "DoctorId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Persons_DoctorId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_DoctorId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Persons");
        }
    }
}
