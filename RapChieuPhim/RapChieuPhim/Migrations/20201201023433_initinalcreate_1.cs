﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RapChieuPhim.Migrations
{
    public partial class initinalcreate_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NguoiDungModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dia_chi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ngay_sinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Admin = table.Column<bool>(type: "bit", nullable: false),
                    Da_xoa = table.Column<bool>(type: "bit", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDungModel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PhimModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten_phim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hinh_anh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Thoi_luong = table.Column<int>(type: "int", nullable: false),
                    Luot_xem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gia_ve = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lich_Chieu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Da_xoa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhimModel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RapPhimModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten_rap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dia_chi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Da_xoa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RapPhimModel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tong_tien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ngay_lap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Da_xoa = table.Column<bool>(type: "bit", nullable: false),
                    ThanhVien_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HoaDonModel_NguoiDungModel_ThanhVien_ID",
                        column: x => x.ThanhVien_ID,
                        principalTable: "NguoiDungModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoanModel",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten_dang_nhap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mat_khau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Loai_tai_khoan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiDung_ID = table.Column<int>(type: "int", nullable: false),
                    Da_xoa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoanModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TaiKhoanModel_NguoiDungModel_NguoiDung_ID",
                        column: x => x.NguoiDung_ID,
                        principalTable: "NguoiDungModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BinhLuanModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThanhVien_ID = table.Column<int>(type: "int", nullable: false),
                    Phim_ID = table.Column<int>(type: "int", nullable: false),
                    Noi_dung = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BinhLuanModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BinhLuanModel_NguoiDungModel_ThanhVien_ID",
                        column: x => x.ThanhVien_ID,
                        principalTable: "NguoiDungModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BinhLuanModel_PhimModel_Phim_ID",
                        column: x => x.Phim_ID,
                        principalTable: "PhimModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LichChieuModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ngay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Da_xoa = table.Column<bool>(type: "bit", nullable: false),
                    RapPhim_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichChieuModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LichChieuModel_RapPhimModel_RapPhim_ID",
                        column: x => x.RapPhim_ID,
                        principalTable: "RapPhimModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhongChieuModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten_Phong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Da_xoa = table.Column<bool>(type: "bit", nullable: false),
                    RapPhim_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongChieuModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PhongChieuModel_RapPhimModel_RapPhim_ID",
                        column: x => x.RapPhim_ID,
                        principalTable: "RapPhimModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "XuatChieuModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Thoi_gian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Da_xoa = table.Column<bool>(type: "bit", nullable: false),
                    LichChieu_ID = table.Column<int>(type: "int", nullable: false),
                    Phim_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XuatChieuModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_XuatChieuModel_LichChieuModel_LichChieu_ID",
                        column: x => x.LichChieu_ID,
                        principalTable: "LichChieuModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_XuatChieuModel_PhimModel_Phim_ID",
                        column: x => x.Phim_ID,
                        principalTable: "PhimModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GheModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Loai = table.Column<int>(type: "int", nullable: false),
                    Da_chon = table.Column<bool>(type: "bit", nullable: false),
                    Da_xoa = table.Column<bool>(type: "bit", nullable: false),
                    PhongChieu_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GheModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GheModel_PhongChieuModel_PhongChieu_ID",
                        column: x => x.PhongChieu_ID,
                        principalTable: "PhongChieuModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VeXemPhimModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Thoi_gian = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ghe_ID = table.Column<int>(type: "int", nullable: true),
                    RapPhim_ID = table.Column<int>(type: "int", nullable: true),
                    Phim_ID = table.Column<int>(type: "int", nullable: true),
                    HoaDon_ID = table.Column<int>(type: "int", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeXemPhimModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_VeXemPhimModel_GheModel_Ghe_ID",
                        column: x => x.Ghe_ID,
                        principalTable: "GheModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VeXemPhimModel_HoaDonModel_HoaDon_ID",
                        column: x => x.HoaDon_ID,
                        principalTable: "HoaDonModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VeXemPhimModel_PhimModel_Phim_ID",
                        column: x => x.Phim_ID,
                        principalTable: "PhimModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VeXemPhimModel_RapPhimModel_RapPhim_ID",
                        column: x => x.RapPhim_ID,
                        principalTable: "RapPhimModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BinhLuanModel_Phim_ID",
                table: "BinhLuanModel",
                column: "Phim_ID");

            migrationBuilder.CreateIndex(
                name: "IX_BinhLuanModel_ThanhVien_ID",
                table: "BinhLuanModel",
                column: "ThanhVien_ID");

            migrationBuilder.CreateIndex(
                name: "IX_GheModel_PhongChieu_ID",
                table: "GheModel",
                column: "PhongChieu_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonModel_ThanhVien_ID",
                table: "HoaDonModel",
                column: "ThanhVien_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LichChieuModel_RapPhim_ID",
                table: "LichChieuModel",
                column: "RapPhim_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PhongChieuModel_RapPhim_ID",
                table: "PhongChieuModel",
                column: "RapPhim_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoanModel_NguoiDung_ID",
                table: "TaiKhoanModel",
                column: "NguoiDung_ID");

            migrationBuilder.CreateIndex(
                name: "IX_VeXemPhimModel_Ghe_ID",
                table: "VeXemPhimModel",
                column: "Ghe_ID");

            migrationBuilder.CreateIndex(
                name: "IX_VeXemPhimModel_HoaDon_ID",
                table: "VeXemPhimModel",
                column: "HoaDon_ID");

            migrationBuilder.CreateIndex(
                name: "IX_VeXemPhimModel_Phim_ID",
                table: "VeXemPhimModel",
                column: "Phim_ID");

            migrationBuilder.CreateIndex(
                name: "IX_VeXemPhimModel_RapPhim_ID",
                table: "VeXemPhimModel",
                column: "RapPhim_ID");

            migrationBuilder.CreateIndex(
                name: "IX_XuatChieuModel_LichChieu_ID",
                table: "XuatChieuModel",
                column: "LichChieu_ID");

            migrationBuilder.CreateIndex(
                name: "IX_XuatChieuModel_Phim_ID",
                table: "XuatChieuModel",
                column: "Phim_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BinhLuanModel");

            migrationBuilder.DropTable(
                name: "TaiKhoanModel");

            migrationBuilder.DropTable(
                name: "VeXemPhimModel");

            migrationBuilder.DropTable(
                name: "XuatChieuModel");

            migrationBuilder.DropTable(
                name: "GheModel");

            migrationBuilder.DropTable(
                name: "HoaDonModel");

            migrationBuilder.DropTable(
                name: "LichChieuModel");

            migrationBuilder.DropTable(
                name: "PhimModel");

            migrationBuilder.DropTable(
                name: "PhongChieuModel");

            migrationBuilder.DropTable(
                name: "NguoiDungModel");

            migrationBuilder.DropTable(
                name: "RapPhimModel");
        }
    }
}
