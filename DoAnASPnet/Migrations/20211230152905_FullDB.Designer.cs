﻿// <auto-generated />
using System;
using DoAnASPnet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DoAnASPnet.Migrations
{
    [DbContext(typeof(DoAnASPnetContext))]
    [Migration("20211230152905_FullDB")]
    partial class FullDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DoAnASPnet.Models.Chitietdonhang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Dongia")
                        .HasColumnType("int");

                    b.Property<int>("DonhangId")
                        .HasColumnType("int");

                    b.Property<int>("SanphamId")
                        .HasColumnType("int");

                    b.Property<int>("Soluong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DonhangId");

                    b.HasIndex("SanphamId");

                    b.ToTable("Chitietdonhang");
                });

            modelBuilder.Entity("DoAnASPnet.Models.Donhang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Madon")
                        .HasColumnType("int");

                    b.Property<DateTime>("Ngaydat")
                        .HasColumnType("datetime2");

                    b.Property<int>("NguoidungId")
                        .HasColumnType("int");

                    b.Property<bool>("Tinhtrang")
                        .HasColumnType("bit");

                    b.Property<int>("Tongtien")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NguoidungId");

                    b.ToTable("Donhang");
                });

            modelBuilder.Entity("DoAnASPnet.Models.Hangsanxuat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Mahang")
                        .HasColumnType("int");

                    b.Property<string>("Tenhang")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hangsanxuat");
                });

            modelBuilder.Entity("DoAnASPnet.Models.Hedieuhanh", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Mahdh")
                        .HasColumnType("int");

                    b.Property<string>("Tenhdh")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hedieuhanh");
                });

            modelBuilder.Entity("DoAnASPnet.Models.Nguoidung", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Diachi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dienthoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Hoten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaNguoiDung")
                        .HasColumnType("int");

                    b.Property<string>("Matkhau")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("PhanquyenId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PhanquyenId");

                    b.ToTable("Nguoidung");
                });

            modelBuilder.Entity("DoAnASPnet.Models.Phanquyen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IDQuyen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tenquyen")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Phanquyen");
                });

            modelBuilder.Entity("DoAnASPnet.Models.Sanpham", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Anhbia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Giatien")
                        .HasColumnType("int");

                    b.Property<int>("HangsanxuatId")
                        .HasColumnType("int");

                    b.Property<int>("HedieuhanhId")
                        .HasColumnType("int");

                    b.Property<int>("Masp")
                        .HasColumnType("int");

                    b.Property<string>("Mota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Soluong")
                        .HasColumnType("int");

                    b.Property<string>("Tensp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HangsanxuatId");

                    b.HasIndex("HedieuhanhId");

                    b.ToTable("Sanpham");
                });

            modelBuilder.Entity("DoAnASPnet.Models.Chitietdonhang", b =>
                {
                    b.HasOne("DoAnASPnet.Models.Donhang", "Donhang")
                        .WithMany("Chitietdonhangs")
                        .HasForeignKey("DonhangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoAnASPnet.Models.Sanpham", "Sanpham")
                        .WithMany("Chitietdonhangs")
                        .HasForeignKey("SanphamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Donhang");

                    b.Navigation("Sanpham");
                });

            modelBuilder.Entity("DoAnASPnet.Models.Donhang", b =>
                {
                    b.HasOne("DoAnASPnet.Models.Nguoidung", "Nguoidung")
                        .WithMany("Donhangs")
                        .HasForeignKey("NguoidungId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nguoidung");
                });

            modelBuilder.Entity("DoAnASPnet.Models.Nguoidung", b =>
                {
                    b.HasOne("DoAnASPnet.Models.Phanquyen", "Phanquyen")
                        .WithMany("Nguoidungs")
                        .HasForeignKey("PhanquyenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Phanquyen");
                });

            modelBuilder.Entity("DoAnASPnet.Models.Sanpham", b =>
                {
                    b.HasOne("DoAnASPnet.Models.Hangsanxuat", "Hangsanxuat")
                        .WithMany("Sanphams")
                        .HasForeignKey("HangsanxuatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoAnASPnet.Models.Hedieuhanh", "Hedieuhanh")
                        .WithMany("Sanphams")
                        .HasForeignKey("HedieuhanhId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hangsanxuat");

                    b.Navigation("Hedieuhanh");
                });

            modelBuilder.Entity("DoAnASPnet.Models.Donhang", b =>
                {
                    b.Navigation("Chitietdonhangs");
                });

            modelBuilder.Entity("DoAnASPnet.Models.Hangsanxuat", b =>
                {
                    b.Navigation("Sanphams");
                });

            modelBuilder.Entity("DoAnASPnet.Models.Hedieuhanh", b =>
                {
                    b.Navigation("Sanphams");
                });

            modelBuilder.Entity("DoAnASPnet.Models.Nguoidung", b =>
                {
                    b.Navigation("Donhangs");
                });

            modelBuilder.Entity("DoAnASPnet.Models.Phanquyen", b =>
                {
                    b.Navigation("Nguoidungs");
                });

            modelBuilder.Entity("DoAnASPnet.Models.Sanpham", b =>
                {
                    b.Navigation("Chitietdonhangs");
                });
#pragma warning restore 612, 618
        }
    }
}
