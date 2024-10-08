﻿// <auto-generated />
using System;
using ApiQuanLyNhaThuoc.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiQuanLyNhaThuoc.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240906080936_ModifySomeFieldd")]
    partial class ModifySomeFieldd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Entities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Entities.DanhMuc", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenDanhMuc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DanhMuc");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0e5882fa-0a61-4c81-8e7b-ce9e945a58bb"),
                            CreatedDate = new DateTime(2024, 9, 6, 15, 9, 35, 704, DateTimeKind.Local).AddTicks(4986),
                            MoTa = "Thuốc dị ứng",
                            ModifiedDate = new DateTime(2024, 9, 6, 15, 9, 35, 704, DateTimeKind.Local).AddTicks(4997),
                            TenDanhMuc = "Thuốc"
                        },
                        new
                        {
                            Id = new Guid("dffcb110-463d-40ac-b786-cd1ba91901ad"),
                            CreatedDate = new DateTime(2024, 9, 6, 15, 9, 35, 704, DateTimeKind.Local).AddTicks(5012),
                            MoTa = "Thuốc da liễu",
                            ModifiedDate = new DateTime(2024, 9, 6, 15, 9, 35, 704, DateTimeKind.Local).AddTicks(5012),
                            TenDanhMuc = "Thuốc"
                        },
                        new
                        {
                            Id = new Guid("4c16a760-1944-4467-84bd-a91559f70640"),
                            CreatedDate = new DateTime(2024, 9, 6, 15, 9, 35, 704, DateTimeKind.Local).AddTicks(5014),
                            MoTa = "Thuốc hô hấp",
                            ModifiedDate = new DateTime(2024, 9, 6, 15, 9, 35, 704, DateTimeKind.Local).AddTicks(5015),
                            TenDanhMuc = "Thuốc"
                        },
                        new
                        {
                            Id = new Guid("82489dbb-d14d-413f-9eee-4f06eeec8f79"),
                            CreatedDate = new DateTime(2024, 9, 6, 15, 9, 35, 704, DateTimeKind.Local).AddTicks(5016),
                            MoTa = "Vitamin & Khoáng chất",
                            ModifiedDate = new DateTime(2024, 9, 6, 15, 9, 35, 704, DateTimeKind.Local).AddTicks(5017),
                            TenDanhMuc = "Thực phẩm chứng năng"
                        },
                        new
                        {
                            Id = new Guid("8e40ecec-5965-4cc1-afab-a5e64128c6bc"),
                            CreatedDate = new DateTime(2024, 9, 6, 15, 9, 35, 704, DateTimeKind.Local).AddTicks(5019),
                            MoTa = "Hỗ trợ làm đẹp",
                            ModifiedDate = new DateTime(2024, 9, 6, 15, 9, 35, 704, DateTimeKind.Local).AddTicks(5019),
                            TenDanhMuc = "Thực phẩm chứng năng"
                        },
                        new
                        {
                            Id = new Guid("e37c8fce-dc22-4f57-9b25-f4d1ec7c6d33"),
                            CreatedDate = new DateTime(2024, 9, 6, 15, 9, 35, 704, DateTimeKind.Local).AddTicks(5021),
                            MoTa = "Dinh dưỡng",
                            ModifiedDate = new DateTime(2024, 9, 6, 15, 9, 35, 704, DateTimeKind.Local).AddTicks(5021),
                            TenDanhMuc = "Thực phẩm chứng năng"
                        });
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Entities.NhaCungCap", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("QuocGia")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("TenNhaCungCap")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("ThanhPho")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("TrangThaiGiaoDich")
                        .HasColumnType("int");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("NhaCungCap");
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Entities.SanPham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AnhSanPham")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DanhMucId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DonViTinhNhoNhat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DuongDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HangSanXuat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoatChatChinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoaiThuoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaThuoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaVach")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NuocSanXuat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuyCachDongGoi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDangKy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenSanPham")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThaiBan")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DanhMucId");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Models.Entities.ChiTietHoaDonDatHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("HoaDonDatHangId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PhienBanSanPhamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("SoLuongDat")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("HoaDonDatHangId");

                    b.HasIndex("PhienBanSanPhamId");

                    b.ToTable("ChiTietHoaDonDatHang");
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Models.Entities.ChiTietHoaDonNhapHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("HoaDonNhapHangId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LoHangId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PhienBanSanPhamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("SoLuongNhap")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("HoaDonNhapHangId");

                    b.HasIndex("LoHangId");

                    b.HasIndex("PhienBanSanPhamId");

                    b.ToTable("ChiTietHoaDonNhapHang");
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Models.Entities.HangTonKho", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("KhoHangId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PhienBanSanPhamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("SoLuongCoTheBan")
                        .HasColumnType("float");

                    b.Property<double>("SoLuongDangVe")
                        .HasColumnType("float");

                    b.Property<double>("SoLuongTrongKho")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("KhoHangId");

                    b.HasIndex("PhienBanSanPhamId");

                    b.ToTable("HangTonKho");
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Models.Entities.HoaDonDatHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("NhaCungCapId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TrangThaiNhap")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NhaCungCapId");

                    b.ToTable("HoaDonDatHang");
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Models.Entities.HoaDonNhapHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HoaDonDatHangId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("KhoHangId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayNhapHang")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("NhaCungCapId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TrangThaiThanhToan")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HoaDonDatHangId");

                    b.HasIndex("KhoHangId");

                    b.HasIndex("NhaCungCapId");

                    b.ToTable("HoaDonNhapHang");
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Models.Entities.KhoHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PhienBanSanPhamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ViTriLuuTru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PhienBanSanPhamId");

                    b.ToTable("KhoHang");
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Models.Entities.LoHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("KhoHangId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaLoHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayHetHan")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgaySanXuat")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("NhaCungCapId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PhienBanSanPhamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("SoLuongQuyDoi")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("KhoHangId");

                    b.HasIndex("NhaCungCapId");

                    b.HasIndex("PhienBanSanPhamId");

                    b.ToTable("LoHang");
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Models.Entities.PhienBanSanPham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DonViQuyDoi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("GiaBanQuyDoi")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GiaNhapQuyDoi")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("MaSanPham")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaVach")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SanPhamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("SoLuong")
                        .HasColumnType("float");

                    b.Property<string>("TenQuyDoi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThaiBan")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SanPhamId");

                    b.ToTable("PhienBanSanPham");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Entities.SanPham", b =>
                {
                    b.HasOne("ApiQuanLyNhaThuoc.Models.Entities.DanhMuc", "DanhMuc")
                        .WithMany()
                        .HasForeignKey("DanhMucId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DanhMuc");
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Models.Entities.ChiTietHoaDonDatHang", b =>
                {
                    b.HasOne("ApiQuanLyNhaThuoc.Models.Models.Entities.HoaDonDatHang", "HoaDonDatHang")
                        .WithMany("ChiTietHoaDonDatHangs")
                        .HasForeignKey("HoaDonDatHangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiQuanLyNhaThuoc.Models.Models.Entities.PhienBanSanPham", "PhienBanSanPham")
                        .WithMany("ChiTietHoaDonDatHangs")
                        .HasForeignKey("PhienBanSanPhamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDonDatHang");

                    b.Navigation("PhienBanSanPham");
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Models.Entities.ChiTietHoaDonNhapHang", b =>
                {
                    b.HasOne("ApiQuanLyNhaThuoc.Models.Models.Entities.HoaDonNhapHang", "HoaDonNhapHang")
                        .WithMany("ChiTietHoaDonNhapHangs")
                        .HasForeignKey("HoaDonNhapHangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiQuanLyNhaThuoc.Models.Models.Entities.LoHang", "LoHang")
                        .WithMany()
                        .HasForeignKey("LoHangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiQuanLyNhaThuoc.Models.Models.Entities.PhienBanSanPham", "PhienBanSanPham")
                        .WithMany("ChiTietHoaDonNhapHangs")
                        .HasForeignKey("PhienBanSanPhamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDonNhapHang");

                    b.Navigation("LoHang");

                    b.Navigation("PhienBanSanPham");
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Models.Entities.HangTonKho", b =>
                {
                    b.HasOne("ApiQuanLyNhaThuoc.Models.Models.Entities.KhoHang", "KhoHang")
                        .WithMany("HangTonKhos")
                        .HasForeignKey("KhoHangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiQuanLyNhaThuoc.Models.Models.Entities.PhienBanSanPham", "PhienBanSanPham")
                        .WithMany()
                        .HasForeignKey("PhienBanSanPhamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhoHang");

                    b.Navigation("PhienBanSanPham");
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Models.Entities.HoaDonDatHang", b =>
                {
                    b.HasOne("ApiQuanLyNhaThuoc.Models.Entities.NhaCungCap", "NhaCungCap")
                        .WithMany()
                        .HasForeignKey("NhaCungCapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhaCungCap");
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Models.Entities.HoaDonNhapHang", b =>
                {
                    b.HasOne("ApiQuanLyNhaThuoc.Models.Models.Entities.HoaDonDatHang", "HoaDonDatHang")
                        .WithMany("HoaDonNhapHangs")
                        .HasForeignKey("HoaDonDatHangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiQuanLyNhaThuoc.Models.Models.Entities.KhoHang", "KhoHang")
                        .WithMany("HoaDonNhapHangs")
                        .HasForeignKey("KhoHangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiQuanLyNhaThuoc.Models.Entities.NhaCungCap", null)
                        .WithMany("HoaDonNhapHangs")
                        .HasForeignKey("NhaCungCapId");

                    b.Navigation("HoaDonDatHang");

                    b.Navigation("KhoHang");
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Models.Entities.KhoHang", b =>
                {
                    b.HasOne("ApiQuanLyNhaThuoc.Models.Models.Entities.PhienBanSanPham", null)
                        .WithMany("KhoHangs")
                        .HasForeignKey("PhienBanSanPhamId");
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Models.Entities.LoHang", b =>
                {
                    b.HasOne("ApiQuanLyNhaThuoc.Models.Models.Entities.KhoHang", "KhoHang")
                        .WithMany("LoHangs")
                        .HasForeignKey("KhoHangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiQuanLyNhaThuoc.Models.Entities.NhaCungCap", "NhaCungCap")
                        .WithMany("LoHangs")
                        .HasForeignKey("NhaCungCapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiQuanLyNhaThuoc.Models.Models.Entities.PhienBanSanPham", "PhienBanSanPham")
                        .WithMany("LoHangs")
                        .HasForeignKey("PhienBanSanPhamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhoHang");

                    b.Navigation("NhaCungCap");

                    b.Navigation("PhienBanSanPham");
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Models.Entities.PhienBanSanPham", b =>
                {
                    b.HasOne("ApiQuanLyNhaThuoc.Models.Entities.SanPham", "SanPham")
                        .WithMany("DanhSachPhienBan")
                        .HasForeignKey("SanPhamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ApiQuanLyNhaThuoc.Models.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ApiQuanLyNhaThuoc.Models.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiQuanLyNhaThuoc.Models.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ApiQuanLyNhaThuoc.Models.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Entities.NhaCungCap", b =>
                {
                    b.Navigation("HoaDonNhapHangs");

                    b.Navigation("LoHangs");
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Entities.SanPham", b =>
                {
                    b.Navigation("DanhSachPhienBan");
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Models.Entities.HoaDonDatHang", b =>
                {
                    b.Navigation("ChiTietHoaDonDatHangs");

                    b.Navigation("HoaDonNhapHangs");
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Models.Entities.HoaDonNhapHang", b =>
                {
                    b.Navigation("ChiTietHoaDonNhapHangs");
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Models.Entities.KhoHang", b =>
                {
                    b.Navigation("HangTonKhos");

                    b.Navigation("HoaDonNhapHangs");

                    b.Navigation("LoHangs");
                });

            modelBuilder.Entity("ApiQuanLyNhaThuoc.Models.Models.Entities.PhienBanSanPham", b =>
                {
                    b.Navigation("ChiTietHoaDonDatHangs");

                    b.Navigation("ChiTietHoaDonNhapHangs");

                    b.Navigation("KhoHangs");

                    b.Navigation("LoHangs");
                });
#pragma warning restore 612, 618
        }
    }
}
