using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheShivisiApp.Models.Migrations;

public partial class AddInitBearer : Migration {
  protected override void Up(MigrationBuilder migrationBuilder) =>
    migrationBuilder.UpdateData(
          table: "Settings",
          keyColumn: "Id",
          keyValue: 1,
          column: "BearerToken",
          value: "=@$11~AN-F@S$3~O-A0~Xk$-R=q~w$B-i~a$ol-M@q=_$Dt~g@k-$m2~WE-T6~b=@MZ$7-uF@~1$RA-@KT=$Yh@~h-~sq$qA~O=@-dD~Nu$Cl0~A-8~Oy$Zz~I-TN~GQ~R=@C~TN-2$H~cj~M-$ku~W=");

  protected override void Down(MigrationBuilder migrationBuilder) =>
    migrationBuilder.UpdateData(
          table: "Settings",
          keyColumn: "Id",
          keyValue: 1,
          column: "BearerToken",
          value: "");
}
