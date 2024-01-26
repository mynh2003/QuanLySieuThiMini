USE [master]
GO
/****** Object:  Database [Quanly_sieuthimin]    Script Date: 06/01/2024 10:26:29 CH ******/
CREATE DATABASE [Quanly_sieuthimin]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Quanly_sieuthimin', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Quanly_sieuthimin.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Quanly_sieuthimin_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Quanly_sieuthimin_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Quanly_sieuthimin] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Quanly_sieuthimin].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Quanly_sieuthimin] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Quanly_sieuthimin] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Quanly_sieuthimin] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Quanly_sieuthimin] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Quanly_sieuthimin] SET ARITHABORT OFF 
GO
ALTER DATABASE [Quanly_sieuthimin] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Quanly_sieuthimin] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Quanly_sieuthimin] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Quanly_sieuthimin] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Quanly_sieuthimin] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Quanly_sieuthimin] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Quanly_sieuthimin] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Quanly_sieuthimin] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Quanly_sieuthimin] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Quanly_sieuthimin] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Quanly_sieuthimin] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Quanly_sieuthimin] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Quanly_sieuthimin] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Quanly_sieuthimin] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Quanly_sieuthimin] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Quanly_sieuthimin] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Quanly_sieuthimin] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Quanly_sieuthimin] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Quanly_sieuthimin] SET  MULTI_USER 
GO
ALTER DATABASE [Quanly_sieuthimin] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Quanly_sieuthimin] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Quanly_sieuthimin] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Quanly_sieuthimin] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Quanly_sieuthimin] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Quanly_sieuthimin] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Quanly_sieuthimin] SET QUERY_STORE = ON
GO
ALTER DATABASE [Quanly_sieuthimin] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Quanly_sieuthimin]
GO
/****** Object:  Table [dbo].[ADMIN]    Script Date: 06/01/2024 10:26:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ADMIN](
	[TaiKhoan] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NULL,
 CONSTRAINT [PK_ADMIN] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CANHANVIEN]    Script Date: 06/01/2024 10:26:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CANHANVIEN](
	[Ngay] [date] NOT NULL,
	[ThuTuCa] [int] NOT NULL,
	[NhanVienKho] [varchar](10) NULL,
	[TrangThaiNVKho] [bit] NULL,
	[NhanVienThuNgan] [varchar](10) NULL,
	[TrangThaiNVThuNgan] [bit] NULL,
 CONSTRAINT [PK_CANHANVIEN_1] PRIMARY KEY CLUSTERED 
(
	[Ngay] ASC,
	[ThuTuCa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_HOADON]    Script Date: 06/01/2024 10:26:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_HOADON](
	[MaHD] [varchar](10) NOT NULL,
	[MaHH] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[GiaBan] [nchar](10) NULL,
 CONSTRAINT [PK_CT_HOADON] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_PHIEUNHAP]    Script Date: 06/01/2024 10:26:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHIEUNHAP](
	[MaPN] [varchar](10) NOT NULL,
	[MaHH] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[GiaNhap] [int] NULL,
 CONSTRAINT [PK_CT_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_PHIEUXUAT]    Script Date: 06/01/2024 10:26:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHIEUXUAT](
	[MaPX] [varchar](10) NOT NULL,
	[MaHH] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_CT_PHIEUXUAT] PRIMARY KEY CLUSTERED 
(
	[MaPX] ASC,
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 06/01/2024 10:26:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[MaHH] [varchar](10) NOT NULL,
	[TenHH] [nvarchar](50) NULL,
	[SoLuongTrongKho] [int] NULL,
	[SoLuongNgoaiQuay] [int] NULL,
	[DonViTinh] [nvarchar](50) NULL,
	[HSD] [nvarchar](15) NULL,
	[NoiSX] [nvarchar](50) NULL,
 CONSTRAINT [PK_HANGHOA] PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 06/01/2024 10:26:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHD] [varchar](10) NOT NULL,
	[MaNV] [varchar](10) NULL,
	[ThoiGianTao] [time](0) NULL,
	[NgayTao] [date] NULL,
	[TongTien] [int] NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 06/01/2024 10:26:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MaNCC] [varchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [varchar](50) NULL,
	[CongNo] [int] NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 06/01/2024 10:26:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [varchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[GioiTinh] [bit] NULL,
	[QueQuan] [nvarchar](50) NULL,
	[SDT] [varchar](50) NULL,
	[ViTriLamViec] [nvarchar](50) NULL,
	[TaiKhoan] [varchar](50) NULL,
	[MatKhau] [varchar](50) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 06/01/2024 10:26:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MaPN] [varchar](10) NOT NULL,
	[MaNCC] [varchar](10) NULL,
	[MaNV] [varchar](10) NULL,
	[NgayNhap] [date] NULL,
	[TongTien] [int] NULL,
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUXUAT]    Script Date: 06/01/2024 10:26:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUXUAT](
	[MaPX] [varchar](10) NOT NULL,
	[NgayXuat] [date] NULL,
	[MaNV] [varchar](10) NULL,
 CONSTRAINT [PK_PHIEUXUAT] PRIMARY KEY CLUSTERED 
(
	[MaPX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ADMIN] ([TaiKhoan], [MatKhau]) VALUES (N'admin', N'1')
INSERT [dbo].[ADMIN] ([TaiKhoan], [MatKhau]) VALUES (N'admin1', N'1')
INSERT [dbo].[ADMIN] ([TaiKhoan], [MatKhau]) VALUES (N'admin2', N'1')
GO
INSERT [dbo].[CANHANVIEN] ([Ngay], [ThuTuCa], [NhanVienKho], [TrangThaiNVKho], [NhanVienThuNgan], [TrangThaiNVThuNgan]) VALUES (CAST(N'2023-11-01' AS Date), 1, N'NV003', 1, N'NV001', 1)
INSERT [dbo].[CANHANVIEN] ([Ngay], [ThuTuCa], [NhanVienKho], [TrangThaiNVKho], [NhanVienThuNgan], [TrangThaiNVThuNgan]) VALUES (CAST(N'2023-11-01' AS Date), 2, N'NV005', 1, N'NV002', 1)
INSERT [dbo].[CANHANVIEN] ([Ngay], [ThuTuCa], [NhanVienKho], [TrangThaiNVKho], [NhanVienThuNgan], [TrangThaiNVThuNgan]) VALUES (CAST(N'2023-11-01' AS Date), 3, N'NV008', 1, N'NV004', 1)
INSERT [dbo].[CANHANVIEN] ([Ngay], [ThuTuCa], [NhanVienKho], [TrangThaiNVKho], [NhanVienThuNgan], [TrangThaiNVThuNgan]) VALUES (CAST(N'2023-11-02' AS Date), 1, N'NV003', 1, N'NV006', 1)
INSERT [dbo].[CANHANVIEN] ([Ngay], [ThuTuCa], [NhanVienKho], [TrangThaiNVKho], [NhanVienThuNgan], [TrangThaiNVThuNgan]) VALUES (CAST(N'2023-11-02' AS Date), 2, N'NV005', 1, N'NV007', 1)
INSERT [dbo].[CANHANVIEN] ([Ngay], [ThuTuCa], [NhanVienKho], [TrangThaiNVKho], [NhanVienThuNgan], [TrangThaiNVThuNgan]) VALUES (CAST(N'2023-11-02' AS Date), 3, N'NV008', 1, N'NV009', 1)
INSERT [dbo].[CANHANVIEN] ([Ngay], [ThuTuCa], [NhanVienKho], [TrangThaiNVKho], [NhanVienThuNgan], [TrangThaiNVThuNgan]) VALUES (CAST(N'2023-11-03' AS Date), 1, N'NV003', 1, N'NV001', 1)
INSERT [dbo].[CANHANVIEN] ([Ngay], [ThuTuCa], [NhanVienKho], [TrangThaiNVKho], [NhanVienThuNgan], [TrangThaiNVThuNgan]) VALUES (CAST(N'2023-11-04' AS Date), 2, N'NV005', 1, N'NV002', 1)
INSERT [dbo].[CANHANVIEN] ([Ngay], [ThuTuCa], [NhanVienKho], [TrangThaiNVKho], [NhanVienThuNgan], [TrangThaiNVThuNgan]) VALUES (CAST(N'2023-11-05' AS Date), 3, N'NV008', 1, N'NV004', 1)
INSERT [dbo].[CANHANVIEN] ([Ngay], [ThuTuCa], [NhanVienKho], [TrangThaiNVKho], [NhanVienThuNgan], [TrangThaiNVThuNgan]) VALUES (CAST(N'2023-11-06' AS Date), 1, N'NV003', 1, N'NV006', 1)
INSERT [dbo].[CANHANVIEN] ([Ngay], [ThuTuCa], [NhanVienKho], [TrangThaiNVKho], [NhanVienThuNgan], [TrangThaiNVThuNgan]) VALUES (CAST(N'2023-11-07' AS Date), 2, N'NV005', 1, N'NV007', 1)
INSERT [dbo].[CANHANVIEN] ([Ngay], [ThuTuCa], [NhanVienKho], [TrangThaiNVKho], [NhanVienThuNgan], [TrangThaiNVThuNgan]) VALUES (CAST(N'2023-11-08' AS Date), 3, N'NV008', 1, N'NV009', 1)
INSERT [dbo].[CANHANVIEN] ([Ngay], [ThuTuCa], [NhanVienKho], [TrangThaiNVKho], [NhanVienThuNgan], [TrangThaiNVThuNgan]) VALUES (CAST(N'2023-11-09' AS Date), 1, N'NV003', 1, N'NV001', 1)
INSERT [dbo].[CANHANVIEN] ([Ngay], [ThuTuCa], [NhanVienKho], [TrangThaiNVKho], [NhanVienThuNgan], [TrangThaiNVThuNgan]) VALUES (CAST(N'2023-11-10' AS Date), 2, N'NV005', 1, N'NV002', 1)
INSERT [dbo].[CANHANVIEN] ([Ngay], [ThuTuCa], [NhanVienKho], [TrangThaiNVKho], [NhanVienThuNgan], [TrangThaiNVThuNgan]) VALUES (CAST(N'2023-12-01' AS Date), 1, N'NV003', 1, N'NV001', 1)
INSERT [dbo].[CANHANVIEN] ([Ngay], [ThuTuCa], [NhanVienKho], [TrangThaiNVKho], [NhanVienThuNgan], [TrangThaiNVThuNgan]) VALUES (CAST(N'2023-12-01' AS Date), 2, N'NV005', 1, N'NV002', 1)
INSERT [dbo].[CANHANVIEN] ([Ngay], [ThuTuCa], [NhanVienKho], [TrangThaiNVKho], [NhanVienThuNgan], [TrangThaiNVThuNgan]) VALUES (CAST(N'2023-12-01' AS Date), 3, N'NV008', 1, N'NV004', 1)
INSERT [dbo].[CANHANVIEN] ([Ngay], [ThuTuCa], [NhanVienKho], [TrangThaiNVKho], [NhanVienThuNgan], [TrangThaiNVThuNgan]) VALUES (CAST(N'2023-12-02' AS Date), 1, N'NV003', 1, N'NV006', 1)
INSERT [dbo].[CANHANVIEN] ([Ngay], [ThuTuCa], [NhanVienKho], [TrangThaiNVKho], [NhanVienThuNgan], [TrangThaiNVThuNgan]) VALUES (CAST(N'2023-12-02' AS Date), 2, N'NV005', 1, N'NV007', 1)
INSERT [dbo].[CANHANVIEN] ([Ngay], [ThuTuCa], [NhanVienKho], [TrangThaiNVKho], [NhanVienThuNgan], [TrangThaiNVThuNgan]) VALUES (CAST(N'2023-12-02' AS Date), 3, N'NV008', 1, N'NV009', 1)
INSERT [dbo].[CANHANVIEN] ([Ngay], [ThuTuCa], [NhanVienKho], [TrangThaiNVKho], [NhanVienThuNgan], [TrangThaiNVThuNgan]) VALUES (CAST(N'2023-12-03' AS Date), 1, N'NV003', 1, N'NV001', 1)
INSERT [dbo].[CANHANVIEN] ([Ngay], [ThuTuCa], [NhanVienKho], [TrangThaiNVKho], [NhanVienThuNgan], [TrangThaiNVThuNgan]) VALUES (CAST(N'2023-12-03' AS Date), 2, N'NV005', 1, N'NV002', 1)
INSERT [dbo].[CANHANVIEN] ([Ngay], [ThuTuCa], [NhanVienKho], [TrangThaiNVKho], [NhanVienThuNgan], [TrangThaiNVThuNgan]) VALUES (CAST(N'2023-12-03' AS Date), 3, N'NV008', 1, N'NV004', 1)
GO
INSERT [dbo].[CT_HOADON] ([MaHD], [MaHH], [SoLuong], [GiaBan]) VALUES (N'HD001', N'HH003', 2, N'18000     ')
INSERT [dbo].[CT_HOADON] ([MaHD], [MaHH], [SoLuong], [GiaBan]) VALUES (N'HD001', N'HH011', 1, N'350000    ')
INSERT [dbo].[CT_HOADON] ([MaHD], [MaHH], [SoLuong], [GiaBan]) VALUES (N'HD002', N'HH008', 1, N'40000     ')
INSERT [dbo].[CT_HOADON] ([MaHD], [MaHH], [SoLuong], [GiaBan]) VALUES (N'HD002', N'HH013', 1, N'110000    ')
INSERT [dbo].[CT_HOADON] ([MaHD], [MaHH], [SoLuong], [GiaBan]) VALUES (N'HD003', N'HH010', 1, N'93000     ')
GO
INSERT [dbo].[CT_PHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [GiaNhap]) VALUES (N'PN001', N'HH003', 20, 15000)
INSERT [dbo].[CT_PHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [GiaNhap]) VALUES (N'PN001', N'HH008', 50, 35000)
INSERT [dbo].[CT_PHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [GiaNhap]) VALUES (N'PN001', N'HH011', 10, 300000)
INSERT [dbo].[CT_PHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [GiaNhap]) VALUES (N'PN001', N'HH013', 10, 100000)
INSERT [dbo].[CT_PHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [GiaNhap]) VALUES (N'PN002', N'HH001', 10, 120000)
INSERT [dbo].[CT_PHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [GiaNhap]) VALUES (N'PN002', N'HH015', 25, 21000)
INSERT [dbo].[CT_PHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [GiaNhap]) VALUES (N'PN003', N'HH002', 15, 10000)
INSERT [dbo].[CT_PHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [GiaNhap]) VALUES (N'PN003', N'HH004', 20, 8000)
INSERT [dbo].[CT_PHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [GiaNhap]) VALUES (N'PN003', N'HH005', 10, 135000)
INSERT [dbo].[CT_PHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [GiaNhap]) VALUES (N'PN003', N'HH006', 15, 45000)
INSERT [dbo].[CT_PHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [GiaNhap]) VALUES (N'PN004', N'HH009', 20, 50000)
INSERT [dbo].[CT_PHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [GiaNhap]) VALUES (N'PN004', N'HH010', 10, 87000)
INSERT [dbo].[CT_PHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [GiaNhap]) VALUES (N'PN004', N'HH012', 20, 25000)
INSERT [dbo].[CT_PHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [GiaNhap]) VALUES (N'PN005', N'HH007', 20, 32000)
INSERT [dbo].[CT_PHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [GiaNhap]) VALUES (N'PN005', N'HH014', 30, 110000)
GO
INSERT [dbo].[CT_PHIEUXUAT] ([MaPX], [MaHH], [SoLuong]) VALUES (N'PX001', N'HH001', 5)
INSERT [dbo].[CT_PHIEUXUAT] ([MaPX], [MaHH], [SoLuong]) VALUES (N'PX001', N'HH002', 10)
INSERT [dbo].[CT_PHIEUXUAT] ([MaPX], [MaHH], [SoLuong]) VALUES (N'PX001', N'HH004', 10)
INSERT [dbo].[CT_PHIEUXUAT] ([MaPX], [MaHH], [SoLuong]) VALUES (N'PX001', N'HH005', 3)
INSERT [dbo].[CT_PHIEUXUAT] ([MaPX], [MaHH], [SoLuong]) VALUES (N'PX001', N'HH006', 7)
INSERT [dbo].[CT_PHIEUXUAT] ([MaPX], [MaHH], [SoLuong]) VALUES (N'PX001', N'HH007', 12)
INSERT [dbo].[CT_PHIEUXUAT] ([MaPX], [MaHH], [SoLuong]) VALUES (N'PX002', N'HH008', 23)
INSERT [dbo].[CT_PHIEUXUAT] ([MaPX], [MaHH], [SoLuong]) VALUES (N'PX002', N'HH009', 12)
INSERT [dbo].[CT_PHIEUXUAT] ([MaPX], [MaHH], [SoLuong]) VALUES (N'PX002', N'HH010', 4)
INSERT [dbo].[CT_PHIEUXUAT] ([MaPX], [MaHH], [SoLuong]) VALUES (N'PX002', N'HH011', 9)
INSERT [dbo].[CT_PHIEUXUAT] ([MaPX], [MaHH], [SoLuong]) VALUES (N'PX003', N'HH012', 11)
INSERT [dbo].[CT_PHIEUXUAT] ([MaPX], [MaHH], [SoLuong]) VALUES (N'PX003', N'HH013', 10)
INSERT [dbo].[CT_PHIEUXUAT] ([MaPX], [MaHH], [SoLuong]) VALUES (N'PX003', N'HH014', 7)
INSERT [dbo].[CT_PHIEUXUAT] ([MaPX], [MaHH], [SoLuong]) VALUES (N'PX003', N'HH015', 13)
INSERT [dbo].[CT_PHIEUXUAT] ([MaPX], [MaHH], [SoLuong]) VALUES (N'PX004', N'HH003', 10)
GO
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [SoLuongTrongKho], [SoLuongNgoaiQuay], [DonViTinh], [HSD], [NoiSX]) VALUES (N'HH001', N'Sữa tươi Vinamilk', 5, 5, N'Thùng', N'2 tháng', N'Việt Nam')
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [SoLuongTrongKho], [SoLuongNgoaiQuay], [DonViTinh], [HSD], [NoiSX]) VALUES (N'HH002', N'Bánh mỳ Sandwich Wonder', 5, 10, N'Cái', N'7 ngày', N'Việt Nam')
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [SoLuongTrongKho], [SoLuongNgoaiQuay], [DonViTinh], [HSD], [NoiSX]) VALUES (N'HH003', N'Nước ngọt Coca-Cola', 10, 8, N'Chai', N'6 tháng', N'Mỹ')
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [SoLuongTrongKho], [SoLuongNgoaiQuay], [DonViTinh], [HSD], [NoiSX]) VALUES (N'HH004', N'Bột ngọt Ajinomoto', 10, 10, N'Gói', N'1 năm', N'Nhật Bản')
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [SoLuongTrongKho], [SoLuongNgoaiQuay], [DonViTinh], [HSD], [NoiSX]) VALUES (N'HH005', N'Mì gói Maruchan', 7, 3, N'Thùng', N'1 năm', N'Nhật Bản')
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [SoLuongTrongKho], [SoLuongNgoaiQuay], [DonViTinh], [HSD], [NoiSX]) VALUES (N'HH006', N'Dầu ăn Simply', 8, 7, N'Chai', N'2 năm', N'Malaysia')
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [SoLuongTrongKho], [SoLuongNgoaiQuay], [DonViTinh], [HSD], [NoiSX]) VALUES (N'HH007', N'Bánh quy Oreo', 8, 12, N'Gói', N'6 tháng', N'Mỹ')
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [SoLuongTrongKho], [SoLuongNgoaiQuay], [DonViTinh], [HSD], [NoiSX]) VALUES (N'HH008', N'Sữa chua Vinamilk', 27, 22, N'Vỷ', N'20 ngày', N'Việt Nam')
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [SoLuongTrongKho], [SoLuongNgoaiQuay], [DonViTinh], [HSD], [NoiSX]) VALUES (N'HH009', N'Nước mắm Phú Quốc', 8, 12, N'Chai', N'2 năm', N'Việt Nam')
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [SoLuongTrongKho], [SoLuongNgoaiQuay], [DonViTinh], [HSD], [NoiSX]) VALUES (N'HH010', N'Sữa tắm Lux', 6, 3, N'Chai', N'3 năm', N'Thái Lan')
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [SoLuongTrongKho], [SoLuongNgoaiQuay], [DonViTinh], [HSD], [NoiSX]) VALUES (N'HH011', N'Bia Tige', 1, 8, N'Thùng', N'6 tháng', N'Việt Nam')
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [SoLuongTrongKho], [SoLuongNgoaiQuay], [DonViTinh], [HSD], [NoiSX]) VALUES (N'HH012', N'Cà phê trung Nguyên', 9, 11, N'Hộp', N'1 năm', N'Việt Nam')
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [SoLuongTrongKho], [SoLuongNgoaiQuay], [DonViTinh], [HSD], [NoiSX]) VALUES (N'HH013', N'Nước suối Lavie', 0, 9, N'Thùng', N'2 năm', N'Việt Nam')
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [SoLuongTrongKho], [SoLuongNgoaiQuay], [DonViTinh], [HSD], [NoiSX]) VALUES (N'HH014', N'Sữa tươi Fami', 23, 7, N'Thùng', N'1 tháng', N'Việt Nam')
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [SoLuongTrongKho], [SoLuongNgoaiQuay], [DonViTinh], [HSD], [NoiSX]) VALUES (N'HH015', N'Nước rửa chén Sunlight', 12, 13, N'Chai', N'3 năm', N'Malaysia')
GO
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [ThoiGianTao], [NgayTao], [TongTien]) VALUES (N'HD001', N'NV001', CAST(N'22:18:00' AS Time), CAST(N'2024-01-06' AS Date), 386000)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [ThoiGianTao], [NgayTao], [TongTien]) VALUES (N'HD002', N'NV001', CAST(N'22:21:00' AS Time), CAST(N'2024-01-06' AS Date), 150000)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [ThoiGianTao], [NgayTao], [TongTien]) VALUES (N'HD003', N'NV002', CAST(N'22:23:00' AS Time), CAST(N'2024-01-06' AS Date), 93000)
GO
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT], [CongNo]) VALUES (N'NCC001', N'Công ty TNHH A', N'Hà Nội', N'0536363636', 6050000)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT], [CongNo]) VALUES (N'NCC002', N'Công ty TNHH B', N'Nam Định', N'0912345678', 1725000)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT], [CongNo]) VALUES (N'NCC003', N'Công ty TNHH C', N'Bắc Ninh', N'0977777777', 2335000)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT], [CongNo]) VALUES (N'NCC004', N'Công ty TNHH D', N'Hải Phòng', N'0966666666', 2370000)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT], [CongNo]) VALUES (N'NCC005', N'Công ty TNHH E', N'Hà Nam', N'0939393939', 3940000)
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [QueQuan], [SDT], [ViTriLamViec], [TaiKhoan], [MatKhau]) VALUES (N'NV001', N'Nguyễn Thị Thu Huệ', 0, N'Ninh Bình', N'0835247247', N'Thu Ngân', N'nguyenhue', N'1234')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [QueQuan], [SDT], [ViTriLamViec], [TaiKhoan], [MatKhau]) VALUES (N'NV002', N'Tran Thi Hoa', 0, N'Nam Định', N'0384924342', N'Thu Ngân', N'tranthihoa', N'1234')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [QueQuan], [SDT], [ViTriLamViec], [TaiKhoan], [MatKhau]) VALUES (N'NV003', N'Lê Bình Minh', 1, N'Thái Bình', N'0363636363', N'Kho', N'lebinhminh', N'1234')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [QueQuan], [SDT], [ViTriLamViec], [TaiKhoan], [MatKhau]) VALUES (N'NV004', N'Ngô Thi Huệ', 0, N'Hà Giang', N'0845642355', N'Thu Ngân', N'ngothuhue', N'1234')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [QueQuan], [SDT], [ViTriLamViec], [TaiKhoan], [MatKhau]) VALUES (N'NV005', N'Lê Ngọc Hải', 1, N'Bắc Giang', N'0868686868', N'Kho', N'lamdinhkhoa', N'1234')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [QueQuan], [SDT], [ViTriLamViec], [TaiKhoan], [MatKhau]) VALUES (N'NV006', N'Nguyen Minh Anh ', 0, N'Hà Nội', N'0576676767', N'Thu Ngân', N'nguyenminhanh', N'1234')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [QueQuan], [SDT], [ViTriLamViec], [TaiKhoan], [MatKhau]) VALUES (N'NV007', N'Nguyễn Văn Nam', 1, N'Thai Binh', N'0565389036', N'Thu Ngân', N'nguyenvannam', N'1234')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [QueQuan], [SDT], [ViTriLamViec], [TaiKhoan], [MatKhau]) VALUES (N'NV008', N'Trần Quốc Hải', 1, N'Ðồng Nai', N'0934342342', N'Kho', N'tranquochai', N'1234')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [QueQuan], [SDT], [ViTriLamViec], [TaiKhoan], [MatKhau]) VALUES (N'NV009', N'Bùi Thu Trà', 0, N'Hưng Yên', N'0386943678', N'Thu Ngân', N'buithutra', N'1234')
GO
INSERT [dbo].[PHIEUNHAP] ([MaPN], [MaNCC], [MaNV], [NgayNhap], [TongTien]) VALUES (N'PN001', N'NCC003', N'NV001', CAST(N'2024-01-06' AS Date), 6050000)
INSERT [dbo].[PHIEUNHAP] ([MaPN], [MaNCC], [MaNV], [NgayNhap], [TongTien]) VALUES (N'PN002', N'NCC002', N'NV005', CAST(N'2024-01-06' AS Date), 1725000)
INSERT [dbo].[PHIEUNHAP] ([MaPN], [MaNCC], [MaNV], [NgayNhap], [TongTien]) VALUES (N'PN003', N'NCC003', N'NV008', CAST(N'2024-01-06' AS Date), 2335000)
INSERT [dbo].[PHIEUNHAP] ([MaPN], [MaNCC], [MaNV], [NgayNhap], [TongTien]) VALUES (N'PN004', N'NCC004', N'NV005', CAST(N'2024-01-06' AS Date), 2370000)
INSERT [dbo].[PHIEUNHAP] ([MaPN], [MaNCC], [MaNV], [NgayNhap], [TongTien]) VALUES (N'PN005', N'NCC005', N'NV003', CAST(N'2024-01-06' AS Date), 3940000)
GO
INSERT [dbo].[PHIEUXUAT] ([MaPX], [NgayXuat], [MaNV]) VALUES (N'PX001', CAST(N'2024-01-06' AS Date), N'NV003')
INSERT [dbo].[PHIEUXUAT] ([MaPX], [NgayXuat], [MaNV]) VALUES (N'PX002', CAST(N'2024-01-06' AS Date), N'NV005')
INSERT [dbo].[PHIEUXUAT] ([MaPX], [NgayXuat], [MaNV]) VALUES (N'PX003', CAST(N'2024-01-06' AS Date), N'NV008')
INSERT [dbo].[PHIEUXUAT] ([MaPX], [NgayXuat], [MaNV]) VALUES (N'PX004', CAST(N'2024-01-06' AS Date), N'NV003')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [uni_taikhoan]    Script Date: 06/01/2024 10:26:29 CH ******/
CREATE UNIQUE NONCLUSTERED INDEX [uni_taikhoan] ON [dbo].[NHANVIEN]
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CANHANVIEN] ADD  CONSTRAINT [DF_CANHANVIEN_TinhTrang]  DEFAULT ((0)) FOR [TrangThaiNVKho]
GO
ALTER TABLE [dbo].[CANHANVIEN] ADD  CONSTRAINT [DF_CANHANVIEN_TrangThaiNVThuNgan]  DEFAULT ((0)) FOR [TrangThaiNVThuNgan]
GO
ALTER TABLE [dbo].[HOADON] ADD  CONSTRAINT [DF_HOADON_ThoiGianTao]  DEFAULT (getdate()) FOR [ThoiGianTao]
GO
ALTER TABLE [dbo].[CANHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NhanVienKho] FOREIGN KEY([NhanVienKho])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[CANHANVIEN] CHECK CONSTRAINT [FK_NhanVienKho]
GO
ALTER TABLE [dbo].[CANHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NhanVienThuNgan] FOREIGN KEY([NhanVienThuNgan])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[CANHANVIEN] CHECK CONSTRAINT [FK_NhanVienThuNgan]
GO
ALTER TABLE [dbo].[CT_HOADON]  WITH CHECK ADD  CONSTRAINT [FK_CT_HOADON_HANGHOA] FOREIGN KEY([MaHH])
REFERENCES [dbo].[HANGHOA] ([MaHH])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CT_HOADON] CHECK CONSTRAINT [FK_CT_HOADON_HANGHOA]
GO
ALTER TABLE [dbo].[CT_HOADON]  WITH CHECK ADD  CONSTRAINT [FK_CT_HOADON_HOADON] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CT_HOADON] CHECK CONSTRAINT [FK_CT_HOADON_HOADON]
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUNHAP_HANGHOA] FOREIGN KEY([MaHH])
REFERENCES [dbo].[HANGHOA] ([MaHH])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP] CHECK CONSTRAINT [FK_CT_PHIEUNHAP_HANGHOA]
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUNHAP_PHIEUNHAP] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PHIEUNHAP] ([MaPN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP] CHECK CONSTRAINT [FK_CT_PHIEUNHAP_PHIEUNHAP]
GO
ALTER TABLE [dbo].[CT_PHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUXUAT_HANGHOA] FOREIGN KEY([MaHH])
REFERENCES [dbo].[HANGHOA] ([MaHH])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CT_PHIEUXUAT] CHECK CONSTRAINT [FK_CT_PHIEUXUAT_HANGHOA]
GO
ALTER TABLE [dbo].[CT_PHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUXUAT_PHIEUXUAT] FOREIGN KEY([MaPX])
REFERENCES [dbo].[PHIEUXUAT] ([MaPX])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CT_PHIEUXUAT] CHECK CONSTRAINT [FK_CT_PHIEUXUAT_PHIEUXUAT]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NHACUNGCAP] ([MaNCC])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUXUAT_PHIEUXUAT] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PHIEUXUAT] CHECK CONSTRAINT [FK_PHIEUXUAT_PHIEUXUAT]
GO
/****** Object:  StoredProcedure [dbo].[ChiTietPN]    Script Date: 06/01/2024 10:26:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ChiTietPN]
    @MaPN varchar(50)
AS
	SELECT 
    CT.MaHH, 
    HH.TenHH, 
    CT.SoLuong, 
    CT.GiaNhap,
    (CT.SoLuong * CT.GiaNhap) AS ThanhTien
FROM 
    CT_PHIEUNHAP CT
JOIN 
    HANGHOA HH ON CT.MaHH = HH.MaHH
WHERE 
    CT.MaPN = @MaPN;
GO
/****** Object:  StoredProcedure [dbo].[ThongTinPN]    Script Date: 06/01/2024 10:26:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThongTinPN]
    @MaPN varchar(10)
AS
   SELECT PN.MaPN, PN.MaNCC, NCC.TenNCC, PN.MaNV, PN.NgayNhap, PN.TongTien
   FROM PHIEUNHAP PN
   JOIN NHACUNGCAP NCC ON NCC.MaNCC = PN.MaNCC
   WHERE MaPN = @MaPN
GO
USE [master]
GO
ALTER DATABASE [Quanly_sieuthimin] SET  READ_WRITE 
GO
