using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BTL_Tu.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhuHuynhs",
                columns: table => new
                {
                    MaSoPhuHuynh = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(nullable: true),
                    SoDienThoai = table.Column<string>(nullable: true),
                    QuanHe = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuHuynhs", x => x.MaSoPhuHuynh);
                });

            migrationBuilder.CreateTable(
                name: "HocSinhs",
                columns: table => new
                {
                    MaSoHocSinh = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(nullable: true),
                    NgaySinh = table.Column<DateTime>(nullable: false),
                    GioiTinh = table.Column<bool>(nullable: false),
                    MaSoPhuHuynh = table.Column<int>(nullable: false),
                    PhuHuynhMaSoPhuHuynh = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocSinhs", x => x.MaSoHocSinh);
                    table.ForeignKey(
                        name: "FK_HocSinhs_PhuHuynhs_PhuHuynhMaSoPhuHuynh",
                        column: x => x.PhuHuynhMaSoPhuHuynh,
                        principalTable: "PhuHuynhs",
                        principalColumn: "MaSoPhuHuynh",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoSos",
                columns: table => new
                {
                    MaSoHoSo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    MaSoHocSinh = table.Column<int>(nullable: false),
                    MoTa = table.Column<string>(nullable: true),
                    HocSinhMaSoHocSinh = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoSos", x => x.MaSoHoSo);
                    table.ForeignKey(
                        name: "FK_HoSos_HocSinhs_HocSinhMaSoHocSinh",
                        column: x => x.HocSinhMaSoHocSinh,
                        principalTable: "HocSinhs",
                        principalColumn: "MaSoHocSinh",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HocSinhs_PhuHuynhMaSoPhuHuynh",
                table: "HocSinhs",
                column: "PhuHuynhMaSoPhuHuynh");

            migrationBuilder.CreateIndex(
                name: "IX_HoSos_HocSinhMaSoHocSinh",
                table: "HoSos",
                column: "HocSinhMaSoHocSinh");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoSos");

            migrationBuilder.DropTable(
                name: "HocSinhs");

            migrationBuilder.DropTable(
                name: "PhuHuynhs");
        }
    }
}
