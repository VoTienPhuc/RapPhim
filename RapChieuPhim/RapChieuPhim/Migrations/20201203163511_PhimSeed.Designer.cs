﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RapChieuPhim.Areas.Admin.Data;

namespace RapChieuPhim.Migrations
{
    [DbContext(typeof(DPContext))]
    [Migration("20201203163511_PhimSeed")]
    partial class PhimSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.BinhLuanModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("NguoiDung_ID")
                        .HasColumnType("int");

                    b.Property<string>("Noi_dung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phim_ID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("NguoiDung_ID");

                    b.HasIndex("Phim_ID");

                    b.ToTable("BinhLuanModel");
                });

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.GheModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Da_chon")
                        .HasColumnType("bit");

                    b.Property<bool>("Da_xoa")
                        .HasColumnType("bit");

                    b.Property<int>("Loai")
                        .HasColumnType("int");

                    b.Property<int>("PhongChieu_ID")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("PhongChieu_ID");

                    b.ToTable("GheModel");
                });

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.HoaDonModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Da_xoa")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Ngay_lap")
                        .HasColumnType("datetime2");

                    b.Property<int>("NguoiDung_ID")
                        .HasColumnType("int");

                    b.Property<string>("Tong_tien")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("NguoiDung_ID");

                    b.ToTable("HoaDonModel");
                });

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.LichChieuModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Da_xoa")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Ngay")
                        .HasColumnType("datetime2");

                    b.Property<int>("RapPhim_ID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RapPhim_ID");

                    b.ToTable("LichChieuModel");
                });

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.NguoiDungModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Admin")
                        .HasColumnType("bit");

                    b.Property<bool>("Da_xoa")
                        .HasColumnType("bit");

                    b.Property<string>("Dia_chi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ngay_sinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sdt")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("NguoiDungModel");
                });

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.PhimModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Da_xoa")
                        .HasColumnType("int");

                    b.Property<string>("Gia_ve")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hinh_anh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lich_Chieu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Luot_xem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten_phim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Thoi_luong")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("PhimModel");

                    b.HasData(
                        new
                        {
                            ID = 4,
                            Da_xoa = 0,
                            Gia_ve = "50000",
                            Hinh_anh = "",
                            Lich_Chieu = "2,4,6",
                            Luot_xem = "3188",
                            Ten_phim = "Dekaranger 10 years after",
                            Thoi_luong = 130
                        },
                        new
                        {
                            ID = 1,
                            Da_xoa = 0,
                            Gia_ve = "80000",
                            Hinh_anh = "",
                            Lich_Chieu = "5,6",
                            Luot_xem = "2203",
                            Ten_phim = "Pacific Rim (2013)",
                            Thoi_luong = 131
                        },
                        new
                        {
                            ID = 2,
                            Da_xoa = 0,
                            Gia_ve = "100000",
                            Hinh_anh = "",
                            Lich_Chieu = "2,3,5,7",
                            Luot_xem = "5849",
                            Ten_phim = "Iron Man 3",
                            Thoi_luong = 190
                        },
                        new
                        {
                            ID = 3,
                            Da_xoa = 0,
                            Gia_ve = "55000",
                            Hinh_anh = "",
                            Lich_Chieu = "4,6,CN",
                            Luot_xem = "1435",
                            Ten_phim = "Spider Man: Home Coming",
                            Thoi_luong = 133
                        });
                });

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.PhongChieuModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Da_xoa")
                        .HasColumnType("bit");

                    b.Property<int>("RapPhim_ID")
                        .HasColumnType("int");

                    b.Property<string>("Ten_Phong")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("RapPhim_ID");

                    b.ToTable("PhongChieuModel");
                });

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.RapPhimModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Da_xoa")
                        .HasColumnType("bit");

                    b.Property<string>("Dia_chi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten_rap")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("RapPhimModel");
                });

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.TaiKhoanModel", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Da_xoa")
                        .HasColumnType("bit");

                    b.Property<string>("Loai_tai_khoan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mat_khau")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NguoiDung_ID")
                        .HasColumnType("int");

                    b.Property<string>("Ten_dang_nhap")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("NguoiDung_ID");

                    b.ToTable("TaiKhoanModel");
                });

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.VeXemPhimModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("DaXoa")
                        .HasColumnType("bit");

                    b.Property<int?>("Ghe_ID")
                        .HasColumnType("int");

                    b.Property<int?>("HoaDon_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Phim_ID")
                        .HasColumnType("int");

                    b.Property<int?>("RapPhim_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Thoi_gian")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("Ghe_ID");

                    b.HasIndex("HoaDon_ID");

                    b.HasIndex("Phim_ID");

                    b.HasIndex("RapPhim_ID");

                    b.ToTable("VeXemPhimModel");
                });

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.XuatChieuModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Da_xoa")
                        .HasColumnType("bit");

                    b.Property<int>("LichChieu_ID")
                        .HasColumnType("int");

                    b.Property<int>("Phim_ID")
                        .HasColumnType("int");

                    b.Property<string>("Thoi_gian")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("LichChieu_ID");

                    b.HasIndex("Phim_ID");

                    b.ToTable("XuatChieuModel");
                });

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.BinhLuanModel", b =>
                {
                    b.HasOne("RapChieuPhim.Areas.Admin.Models.NguoiDungModel", "idNguoiDung")
                        .WithMany("lstBinhLuan")
                        .HasForeignKey("NguoiDung_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RapChieuPhim.Areas.Admin.Models.PhimModel", "idPhim")
                        .WithMany("lstBinhLuan")
                        .HasForeignKey("Phim_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("idNguoiDung");

                    b.Navigation("idPhim");
                });

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.GheModel", b =>
                {
                    b.HasOne("RapChieuPhim.Areas.Admin.Models.PhongChieuModel", "idPhongChieu")
                        .WithMany("lstGhe")
                        .HasForeignKey("PhongChieu_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("idPhongChieu");
                });

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.HoaDonModel", b =>
                {
                    b.HasOne("RapChieuPhim.Areas.Admin.Models.NguoiDungModel", "idNguoiDung")
                        .WithMany("lstHoaDon")
                        .HasForeignKey("NguoiDung_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("idNguoiDung");
                });

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.LichChieuModel", b =>
                {
                    b.HasOne("RapChieuPhim.Areas.Admin.Models.RapPhimModel", "idRapPhim")
                        .WithMany("lstLichChieu")
                        .HasForeignKey("RapPhim_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("idRapPhim");
                });

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.PhongChieuModel", b =>
                {
                    b.HasOne("RapChieuPhim.Areas.Admin.Models.RapPhimModel", "idRapPhim")
                        .WithMany("lstPhongChieu")
                        .HasForeignKey("RapPhim_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("idRapPhim");
                });

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.TaiKhoanModel", b =>
                {
                    b.HasOne("RapChieuPhim.Areas.Admin.Models.NguoiDungModel", "NguoiDungModel")
                        .WithMany("lstTaiKhoan")
                        .HasForeignKey("NguoiDung_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NguoiDungModel");
                });

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.VeXemPhimModel", b =>
                {
                    b.HasOne("RapChieuPhim.Areas.Admin.Models.GheModel", "idGhe")
                        .WithMany("lstVeXemPhim")
                        .HasForeignKey("Ghe_ID");

                    b.HasOne("RapChieuPhim.Areas.Admin.Models.HoaDonModel", "idHoaDon")
                        .WithMany("lstVeXemPhim")
                        .HasForeignKey("HoaDon_ID");

                    b.HasOne("RapChieuPhim.Areas.Admin.Models.PhimModel", "idPhim")
                        .WithMany("lstVeXemPhim")
                        .HasForeignKey("Phim_ID");

                    b.HasOne("RapChieuPhim.Areas.Admin.Models.RapPhimModel", "idRapPhim")
                        .WithMany("lstVeXemPhim")
                        .HasForeignKey("RapPhim_ID");

                    b.Navigation("idGhe");

                    b.Navigation("idHoaDon");

                    b.Navigation("idPhim");

                    b.Navigation("idRapPhim");
                });

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.XuatChieuModel", b =>
                {
                    b.HasOne("RapChieuPhim.Areas.Admin.Models.LichChieuModel", "idLichChieu")
                        .WithMany("lstXuatChieu")
                        .HasForeignKey("LichChieu_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RapChieuPhim.Areas.Admin.Models.PhimModel", "idPhim")
                        .WithMany("lstXuatChieu")
                        .HasForeignKey("Phim_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("idLichChieu");

                    b.Navigation("idPhim");
                });

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.GheModel", b =>
                {
                    b.Navigation("lstVeXemPhim");
                });

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.HoaDonModel", b =>
                {
                    b.Navigation("lstVeXemPhim");
                });

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.LichChieuModel", b =>
                {
                    b.Navigation("lstXuatChieu");
                });

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.NguoiDungModel", b =>
                {
                    b.Navigation("lstBinhLuan");

                    b.Navigation("lstHoaDon");

                    b.Navigation("lstTaiKhoan");
                });

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.PhimModel", b =>
                {
                    b.Navigation("lstBinhLuan");

                    b.Navigation("lstVeXemPhim");

                    b.Navigation("lstXuatChieu");
                });

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.PhongChieuModel", b =>
                {
                    b.Navigation("lstGhe");
                });

            modelBuilder.Entity("RapChieuPhim.Areas.Admin.Models.RapPhimModel", b =>
                {
                    b.Navigation("lstLichChieu");

                    b.Navigation("lstPhongChieu");

                    b.Navigation("lstVeXemPhim");
                });
#pragma warning restore 612, 618
        }
    }
}
