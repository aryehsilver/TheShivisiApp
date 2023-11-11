using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheShivisiApp.Models.Migrations;

public partial class AddBearerToken : Migration {
  protected override void Up(MigrationBuilder migrationBuilder) {
    migrationBuilder.AddColumn<string>(
        name: "BearerToken",
        table: "Settings",
        type: "TEXT",
        nullable: false,
        defaultValue: "");

    migrationBuilder.UpdateData(
        table: "Settings",
        keyColumn: "Id",
        keyValue: 1,
        columns: new[] { "BearerToken", "LastUpdated" },
        values: new object[] { "", new DateTime(2023, 10, 2, 17, 52, 8, 275, DateTimeKind.Local).AddTicks(6869) });
  }

  protected override void Down(MigrationBuilder migrationBuilder) {
    migrationBuilder.DropColumn(
        name: "BearerToken",
        table: "Settings");

    migrationBuilder.UpdateData(
        table: "Settings",
        keyColumn: "Id",
        keyValue: 1,
        column: "LastUpdated",
        value: new DateTime(2023, 9, 26, 15, 16, 28, 256, DateTimeKind.Local).AddTicks(1460));
  }
}
