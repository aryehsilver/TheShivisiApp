using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheShivisiApp.Models.Migrations;

public partial class AddCheckUpdatesOnStartup : Migration {
  protected override void Up(MigrationBuilder migrationBuilder) {
    migrationBuilder.AddColumn<bool>(
        name: "CheckUpdatesOnStartup",
        table: "Settings",
        type: "INTEGER",
        nullable: false,
        defaultValue: false);

    migrationBuilder.UpdateData(
        table: "Settings",
        keyColumn: "Id",
        keyValue: 1,
        columns: new[] { "CheckUpdatesOnStartup", "LastUpdated" },
        values: new object[] { true, new DateTime(2023, 10, 3, 12, 43, 41, 732, DateTimeKind.Local).AddTicks(3493) });
  }

  protected override void Down(MigrationBuilder migrationBuilder) {
    migrationBuilder.DropColumn(
        name: "CheckUpdatesOnStartup",
        table: "Settings");

    migrationBuilder.UpdateData(
        table: "Settings",
        keyColumn: "Id",
        keyValue: 1,
        column: "LastUpdated",
        value: new DateTime(2023, 10, 2, 17, 52, 8, 275, DateTimeKind.Local).AddTicks(6869));
  }
}
