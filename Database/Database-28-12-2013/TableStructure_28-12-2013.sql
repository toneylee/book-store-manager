USE [MANAGERBOOKSTORE]
GO
/****** Object:  Table [dbo].[THELOAI]    Script Date: 12/27/2013 18:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THELOAI](
	[MaTL] [nvarchar](100) NOT NULL,
	[TenTL] [nvarchar](255) NULL,
 CONSTRAINT [PK_THELOAI] PRIMARY KEY CLUSTERED 
(
	[MaTL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[THELOAI] ([MaTL], [TenTL]) VALUES (N'TL0000001', N'Tiếng anh chuyên ngành tin học')
INSERT [dbo].[THELOAI] ([MaTL], [TenTL]) VALUES (N'TL0000002', N'Sinh học')
INSERT [dbo].[THELOAI] ([MaTL], [TenTL]) VALUES (N'TL0000003', N'Toán học')
/****** Object:  Table [dbo].[DAUSACH]    Script Date: 12/27/2013 18:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DAUSACH](
	[MaDauSach] [nvarchar](20) NOT NULL,
	[TenSach] [nvarchar](255) NULL,
	[MaTL] [nvarchar](100) NULL,
 CONSTRAINT [PK_DAUSACH] PRIMARY KEY CLUSTERED 
(
	[MaDauSach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DAUSACH] ([MaDauSach], [TenSach], [MaTL]) VALUES (N'DS0000001', N'Con đường tình yêu và những giấc mơ', N'TL0000003')
INSERT [dbo].[DAUSACH] ([MaDauSach], [TenSach], [MaTL]) VALUES (N'DS0000002', N'Sinh học và môi trường', N'TL0000002')
INSERT [dbo].[DAUSACH] ([MaDauSach], [TenSach], [MaTL]) VALUES (N'DS0000003', N'Sinh học và môi trường', N'TL0000002')
INSERT [dbo].[DAUSACH] ([MaDauSach], [TenSach], [MaTL]) VALUES (N'DS0000004', N'Động vật hoang dã', N'TL0000003')
INSERT [dbo].[DAUSACH] ([MaDauSach], [TenSach], [MaTL]) VALUES (N'DS0000005', N'Tôi là ai, em là ai', N'TL0000003')
/****** Object:  Table [dbo].[TACGIA]    Script Date: 12/27/2013 18:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TACGIA](
	[MaTG] [nvarchar](20) NOT NULL,
	[TenTG] [nvarchar](255) NULL,
	[DiaChi] [nvarchar](255) NULL,
 CONSTRAINT [PK_TACGIA] PRIMARY KEY CLUSTERED 
(
	[MaTG] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TACGIA] ([MaTG], [TenTG], [DiaChi]) VALUES (N'TG0000001', N'Toney Lee', N'Binh Quy - Thang Binh - Quang Nam')
INSERT [dbo].[TACGIA] ([MaTG], [TenTG], [DiaChi]) VALUES (N'TG0000002', N'Thanh Trang', N'Quang Nam')
/****** Object:  Table [dbo].[CHITIETTACGIA]    Script Date: 12/27/2013 18:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETTACGIA](
	[MaDauSach] [nvarchar](20) NOT NULL,
	[MaTG] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_CHITIETTACGIA] PRIMARY KEY CLUSTERED 
(
	[MaDauSach] ASC,
	[MaTG] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHITIETTACGIA] ([MaDauSach], [MaTG]) VALUES (N'DS0000001', N'TG0000001')
INSERT [dbo].[CHITIETTACGIA] ([MaDauSach], [MaTG]) VALUES (N'DS0000001', N'TG0000002')
INSERT [dbo].[CHITIETTACGIA] ([MaDauSach], [MaTG]) VALUES (N'DS0000003', N'TG0000001')
INSERT [dbo].[CHITIETTACGIA] ([MaDauSach], [MaTG]) VALUES (N'DS0000004', N'TG0000002')
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 12/27/2013 18:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAXUATBAN](
	[MaNXB] [nvarchar](20) NOT NULL,
	[TenNXB] [nvarchar](255) NULL,
	[DiaChi] [nvarchar](255) NULL,
 CONSTRAINT [PK_NHAXUATBAN] PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB], [DiaChi]) VALUES (N'NXB0000001', N'Bạch Kim', N'Bình Thạnh - TP Hồ Chí Minh')
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB], [DiaChi]) VALUES (N'NXB0000002', N'Kim Đồng', N'Quận 1 - TP Hà Nội')
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 12/27/2013 18:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [nvarchar](20) NOT NULL,
	[TenKH] [nvarchar](255) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[NgaySinh] [smalldatetime] NULL,
	[SoDienThoai] [nvarchar](20) NULL,
	[Email] [nvarchar](255) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[TienNo] [money] NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [NgaySinh], [SoDienThoai], [Email], [DiaChi], [TienNo]) VALUES (N'KH0000001', N'Lê Đức Sang', N'Nam', CAST(0xA2910000 AS SmallDateTime), N'0978071865', N'ducsangpro.93@gmail.com', N'Quảng Nam', 0.0000)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [NgaySinh], [SoDienThoai], [Email], [DiaChi], [TienNo]) VALUES (N'KH0000002', N'Trần Thị Thanh Trang', N'Nữ', CAST(0xA2910000 AS SmallDateTime), N'01642779979', N'ducsangpro.93@gmail.com', N'Quảng Nam', 0.0000)
/****** Object:  Table [dbo].[SACH]    Script Date: 12/27/2013 18:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[MaSach] [nvarchar](20) NOT NULL,
	[MaDauSach] [nvarchar](20) NULL,
	[MaNXB] [nvarchar](20) NULL,
	[NamXB] [int] NULL,
	[GiaNhap] [money] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_SACH] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[SACH] ([MaSach], [MaDauSach], [MaNXB], [NamXB], [GiaNhap], [SoLuong]) VALUES (N'SA0000003', N'DS0000004', N'NXB0000001', 1993, 0.0000, -50)
INSERT [dbo].[SACH] ([MaSach], [MaDauSach], [MaNXB], [NamXB], [GiaNhap], [SoLuong]) VALUES (N'SA0000004', N'DS0000001', N'NXB0000002', 1993, 10000.0000, -400)
INSERT [dbo].[SACH] ([MaSach], [MaDauSach], [MaNXB], [NamXB], [GiaNhap], [SoLuong]) VALUES (N'SA0000005', N'DS0000004', N'NXB0000002', 1993, 1000.0000, 432200)
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 12/27/2013 18:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MaCV] [nvarchar](20) NOT NULL,
	[TenCV] [nvarchar](255) NULL,
 CONSTRAINT [PK_CHUCVU] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV0000001', N'Quản lý')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV0000002', N'Nhân viên')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV0000003', N'Giám đốc')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV0000004', N'Quản lý hóa đơn')
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/27/2013 18:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nvarchar](20) NOT NULL,
	[TenNV] [nvarchar](255) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[NgaySinh] [date] NULL,
	[Email] [nvarchar](255) NULL,
	[DienThoai] [nvarchar](20) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[NgayVaoLam] [date] NULL,
	[MaCV] [nvarchar](20) NULL,
	[UserName] [nvarchar](255) NULL,
	[Password] [nvarchar](255) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [Email], [DienThoai], [DiaChi], [NgayVaoLam], [MaCV], [UserName], [Password]) VALUES (N'NV0000001', N'Toney Lee', N'Nam', CAST(0xE2370B00 AS Date), N'ducsangpro.93@gmail.com', N'0978071865', N'Quảng Nam', CAST(0xF5370B00 AS Date), N'CV0000003', N'', N'')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [Email], [DienThoai], [DiaChi], [NgayVaoLam], [MaCV], [UserName], [Password]) VALUES (N'NV0000002', N'Toney Lee', N'Nam', CAST(0xE2370B00 AS Date), N'ducsangpro.93@gmail.com', N'0978071865', N'Tp Hà Nội', CAST(0xF5370B00 AS Date), N'CV0000003', N'', N'')
/****** Object:  Table [dbo].[PHIEUNHAPSACH]    Script Date: 12/27/2013 18:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAPSACH](
	[MaPhieuNhap] [nvarchar](20) NOT NULL,
	[MaNV] [nvarchar](20) NULL,
	[NgayNhapSach] [date] NULL,
	[TongSoLuong] [int] NULL,
	[TongTien] [money] NULL,
 CONSTRAINT [PK_PHIEUNHAPSACH] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000001', N'NV0000001', CAST(0xF9370B00 AS Date), 0, 0.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000002', N'NV0000001', CAST(0xF9370B00 AS Date), 0, 0.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000003', N'NV0000001', CAST(0xF9370B00 AS Date), 0, 100.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000004', N'NV0000001', CAST(0xF9370B00 AS Date), 1000000, 10.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000005', N'NV0000001', CAST(0xF9370B00 AS Date), 1000000, 10.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000006', N'NV0000001', CAST(0xF9370B00 AS Date), 1000000, 10.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000007', N'NV0000001', CAST(0xF9370B00 AS Date), 0, 0.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000008', N'NV0000001', CAST(0xF9370B00 AS Date), 0, 0.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000009', N'NV0000001', CAST(0xF9370B00 AS Date), 0, 0.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000010', N'NV0000001', CAST(0xF9370B00 AS Date), 0, 0.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000011', N'NV0000001', CAST(0xF9370B00 AS Date), 0, 0.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000012', N'NV0000001', CAST(0xF9370B00 AS Date), 100000000, 1000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000013', N'NV0000001', CAST(0xF9370B00 AS Date), 100000000, 1000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000014', N'NV0000001', CAST(0xFC370B00 AS Date), 1000000, 100.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000015', N'NV0000001', CAST(0xFC370B00 AS Date), 100000, 100.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000016', N'NV0000001', CAST(0xFC370B00 AS Date), 100000, 100.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000017', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000018', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000019', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000020', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000021', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000022', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000023', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000024', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000025', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000026', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000027', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000028', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000029', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000030', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000031', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000032', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000033', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000034', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000035', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000036', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000037', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000038', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000039', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000040', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000041', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000042', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000043', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000044', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000045', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000046', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000047', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000048', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000049', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000050', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000051', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000052', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000053', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000054', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000055', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000056', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000057', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000058', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
INSERT [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap], [MaNV], [NgayNhapSach], [TongSoLuong], [TongTien]) VALUES (N'PN0000059', N'NV0000001', CAST(0xFC370B00 AS Date), 10000000, 10000.0000)
/****** Object:  Table [dbo].[TONKHO]    Script Date: 12/27/2013 18:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TONKHO](
	[MaTonKho] [nvarchar](20) NOT NULL,
	[MaSach] [nvarchar](20) NULL,
	[TonDau] [int] NULL,
	[TonCuoi] [int] NULL,
	[PhatSinh] [int] NULL,
	[ThangNam] [date] NULL,
 CONSTRAINT [PK_TONKHO] PRIMARY KEY CLUSTERED 
(
	[MaTonKho] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TONKHO] ([MaTonKho], [MaSach], [TonDau], [TonCuoi], [PhatSinh], [ThangNam]) VALUES (N'TK0000001', N'SA0000005', 0, 30000, 30000, CAST(0xFC370B00 AS Date))
/****** Object:  Table [dbo].[CHITIETPHIEUNHAP]    Script Date: 12/27/2013 18:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUNHAP](
	[MaPhieuNhap] [nvarchar](20) NOT NULL,
	[MaSach] [nvarchar](20) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [money] NULL,
	[ThanhTien] [money] NULL,
 CONSTRAINT [PK_CHITIETPHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000001', N'SA0000004', 0, 0.0000, 0.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000002', N'SA0000005', 100, 0.0000, 0.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000003', N'SA0000005', 10, 100000.0000, 1000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000006', N'SA0000005', 0, 0.0000, 0.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000007', N'SA0000005', 0, 0.0000, 0.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000008', N'SA0000004', 0, 0.0000, 0.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000009', N'SA0000004', 0, 0.0000, 0.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000011', N'SA0000005', 1000, 100000.0000, 100000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000012', N'SA0000004', 0, 10000.0000, 0.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000012', N'SA0000005', 1000, 100000.0000, 100000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000013', N'SA0000004', 100, 10000.0000, 1000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000014', N'SA0000005', 100, 1000.0000, 100000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000015', N'SA0000005', 100, 1000.0000, 100000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000016', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000017', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000018', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000019', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000020', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000021', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000022', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000023', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000024', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000025', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000026', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000027', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000028', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000029', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000030', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000031', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000032', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000033', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000034', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000035', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000036', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000037', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000038', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000039', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000040', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000041', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000042', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000043', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000044', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000045', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000046', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000047', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000048', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000049', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000050', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000051', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000052', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000053', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000054', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000055', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000056', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000057', N'SA0000005', 10000, 1000.0000, 10000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'PN0000058', N'SA0000005', 10000, 1000.0000, 10000000.0000)
/****** Object:  Trigger [UpdateBookImportId]    Script Date: 12/27/2013 18:46:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[UpdateBookImportId]
ON [dbo].[CHITIETPHIEUNHAP]
AFTER INSERT
AS
BEGIN
DECLARE @MaSach VARCHAR(15),@SoLuong int, @SoLuongTon int, @SoLuongCuoi int, @GiaNhap money;

Select @MaSach = MaSach from INSERTED
Select @SoLuong = SoLuong from INSERTED
Select @GiaNhap = DonGia from INSERTED
SELECT @SoLuongTon = SoLuong FROM SACH WHERE MaSach = @MaSach 

SET @SoLuongCuoi = @SoLuong + @SoLuongTon
--Lấy phần chuỗi số đằng sau TL rồi tăng lên 1 đơn vị
--SET @NEWValue= REPLACE(@MaxValue,'PN','')+1
-- Kiểm tra NEWValue nếu < 100
-- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 7
--SET @NEW_ID = 'PN'+
  --  CASE
    --   WHEN LEN(@NEWValue)<7
      --    THEN REPLICATE('0',7-LEN(@newValue))
        --  ELSE ''
       --END +
      -- @NEWValue
--Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
UPDATE SACH SET SoLuong = @SoLuongCuoi, GiaNhap = @GiaNhap WHERE MaSach = @MaSach
END
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 12/27/2013 18:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHD] [nvarchar](20) NOT NULL,
	[MaKH] [nvarchar](20) NULL,
	[MaNV] [nvarchar](20) NULL,
	[NgayHD] [date] NULL,
	[TongSoLuong] [int] NULL,
	[TongTien] [money] NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayHD], [TongSoLuong], [TongTien]) VALUES (N'HD0000001', N'KH0000001', N'NV0000001', CAST(0xFB370B00 AS Date), 110, 10000100.0000)
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayHD], [TongSoLuong], [TongTien]) VALUES (N'HD0000002', N'KH0000002', N'NV0000001', CAST(0xFB370B00 AS Date), 110, 10000100.0000)
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayHD], [TongSoLuong], [TongTien]) VALUES (N'HD0000003', N'KH0000002', N'NV0000001', CAST(0xFB370B00 AS Date), 110, 10000100.0000)
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayHD], [TongSoLuong], [TongTien]) VALUES (N'HD0000004', N'KH0000002', N'NV0000001', CAST(0xFB370B00 AS Date), 110, 10000100.0000)
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayHD], [TongSoLuong], [TongTien]) VALUES (N'HD0000005', N'KH0000002', N'NV0000001', CAST(0xFB370B00 AS Date), 110, 10000100.0000)
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayHD], [TongSoLuong], [TongTien]) VALUES (N'HD0000006', N'KH0000002', N'NV0000001', CAST(0xFB370B00 AS Date), 110, 10000100.0000)
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 12/27/2013 18:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[MaHD] [nvarchar](20) NOT NULL,
	[MaSach] [nvarchar](20) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [money] NULL,
	[ThanhTien] [money] NULL,
 CONSTRAINT [PK_CHITIETHOADON] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD0000001', N'SA0000003', 10, 10.0000, 100.0000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD0000001', N'SA0000004', 100, 100000.0000, 10000000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD0000001', N'SA0000005', 0, 0.0000, 0.0000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD0000002', N'SA0000003', 10, 10.0000, 100.0000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD0000002', N'SA0000004', 100, 100000.0000, 10000000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD0000002', N'SA0000005', 0, 0.0000, 0.0000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD0000003', N'SA0000003', 10, 10.0000, 100.0000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD0000003', N'SA0000004', 100, 100000.0000, 10000000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD0000003', N'SA0000005', 0, 0.0000, 0.0000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD0000004', N'SA0000003', 10, 10.0000, 100.0000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD0000004', N'SA0000004', 100, 100000.0000, 10000000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD0000004', N'SA0000005', 0, 0.0000, 0.0000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD0000005', N'SA0000003', 10, 10.0000, 100.0000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD0000005', N'SA0000004', 100, 100000.0000, 10000000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD0000005', N'SA0000005', 0, 0.0000, 0.0000)
/****** Object:  Trigger [UpdateBookExportId]    Script Date: 12/27/2013 18:46:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[UpdateBookExportId]
ON [dbo].[CHITIETHOADON]
AFTER INSERT
AS
BEGIN
DECLARE @MaSach VARCHAR(15),@SoLuong int, @SoLuongTon int, @SoLuongCuoi int;

Select @MaSach = MaSach from INSERTED
Select @SoLuong = SoLuong from INSERTED
SELECT @SoLuongTon = SoLuong FROM SACH WHERE MaSach = @MaSach 

SET @SoLuongCuoi = @SoLuongTon - @SoLuong
--Lấy phần chuỗi số đằng sau TL rồi tăng lên 1 đơn vị
--SET @NEWValue= REPLACE(@MaxValue,'PN','')+1
-- Kiểm tra NEWValue nếu < 100
-- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 7
--SET @NEW_ID = 'PN'+
  --  CASE
    --   WHEN LEN(@NEWValue)<7
      --    THEN REPLICATE('0',7-LEN(@newValue))
        --  ELSE ''
       --END +
      -- @NEWValue
--Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
UPDATE SACH SET SoLuong = @SoLuongCuoi WHERE MaSach = @MaSach
END
GO
/****** Object:  Trigger [AutoIncrementSurvivalId]    Script Date: 12/27/2013 18:46:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[AutoIncrementSurvivalId]
ON [dbo].[TONKHO]
FOR INSERT
AS
BEGIN
DECLARE @MAXValue VARCHAR(15),@NEWValue VARCHAR(15),@NEW_ID VARCHAR(15), @OLD_ID VARCHAR(15);
--Lấy giá trị lớn nhất của MaSacg trong bảng SACH
SELECT @MAXValue=MAX(MaTonKho) FROM TONKHO
--Lấy giá trị ID được chèn vào từ bên ngoài (bất kì, không quan trọng)
select @OLD_ID = MaTonKho from INSERTED
--Lấy phần chuỗi số đằng sau SA rồi tăng lên 1 đơn vị
SET @NEWValue= REPLACE(@MaxValue,'TK','')+1
-- Kiểm tra NEWValue nếu < 100
-- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 7
SET @NEW_ID = 'TK'+
    CASE
       WHEN LEN(@NEWValue)<7
          THEN REPLICATE('0',7-LEN(@newValue))
          ELSE ''
       END +
       @NEWValue
--Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
UPDATE TONKHO SET MaTonKho = @NEW_ID WHERE MaTonKho = @OLD_ID
END
GO
/****** Object:  Trigger [UpdateBookQuatitySurvival]    Script Date: 12/27/2013 18:46:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[UpdateBookQuatitySurvival]
ON [dbo].[CHITIETPHIEUNHAP]
AFTER INSERT
AS
BEGIN
	DECLARE @MaPhieuNhap Varchar(15),@MaSach VARCHAR(15),@MaTonKho VARCHAR(15),@SoLuongNhap int, @SoLuongPhatSinh int,@SoLuongTonDau int,@SoLuongTonCuoi int,@SoLuongPhatSinhCuoi int, @NgayNhap smalldatetime;
	--Lấy thông tin sách từ phiếu nhập
	Select @MaSach = MaSach from INSERTED
	Select @SoLuongNhap = SoLuong from INSERTED
	Select @MaPhieuNhap = MaPhieuNhap from INSERTED
	--
	Select @NgayNhap = NgayNhapSach from THONGTINCT_PHIEUNHAP Where THONGTINCT_PHIEUNHAP.MaPhieuNhap = @MaPhieuNhap
	Select @MaTonKho = MaTonKho from TONKHO where YEAR(ThangNam) = YEAR(@NgayNhap) and MONTH(ThangNam) = MONTH(@NgayNhap) and MaSach = @MaSach
	--
	if @MaTonKho is NOT NULL
	BEGIN
		Select @SoLuongPhatSinh = PhatSinh from TONKHO where MaTonKho = @MaTonKho
		Select @SoLuongTonCuoi = TonCuoi from TONKHO where MaTonKho = @MaTonKho
		 if @SoLuongPhatSinh is NULL
		 begin
		  Set @SoLuongPhatSinhCuoi = @SoLuongNhap;
		 end
		 else 
		 begin
		  Set @SoLuongPhatSinhCuoi = (@SoLuongNhap + @SoLuongPhatSinh)
		 end
		Set @SoLuongTonCuoi = (@SoLuongTonCuoi + @SoLuongNhap)
		Update TONKHO set PhatSinh = @SoLuongPhatSinhCuoi, TonCuoi = @SoLuongTonCuoi where MaTonKho = @MaTonKho
	END
	else
	BEGIN
		--Select @SoLuongTonDau = TonCuoi from TONKHO
		-- where (YEAR(ThangNam) = YEAR(@NgayNhap) and MONTH(ThangNam) = MONTH(@NgayNhap)- 1) or (YEAR(ThangNam) = YEAR(@NgayNhap) and MONTH(ThangNam) = MONTH(@NgayNhap)- 1)  and MaTonKho = @MaTonKho
		Set @SoLuongTonDau = (select Top 1 TonCuoi from TONKHO where MaSach = @MaSach order by MaTonKho desc)
		 if (@SoLuongTonDau) is NULL
			 BEGIN
			  INSERT INTO TONKHO VALUES('TK0000000',@MaSach,0,@SoLuongNhap,@SoLuongNhap,@NgayNhap)
			 END
		 else
			 BEGIN
			 INSERT INTO TONKHO VALUES('TK0000000',@MaSach,@SoLuongTonDau,@SoLuongNhap,(@SoLuongTonDau + @SoLuongNhap),@NgayNhap)
			 END
	 END
END
--Lấy phần chuỗi số đằng sau TL rồi tăng lên 1 đơn vị
--SET @NEWValue= REPLACE(@MaxValue,'PN','')+1
-- Kiểm tra NEWValue nếu < 100
-- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 7
--SET @NEW_ID = 'PN'+
  --  CASE
    --   WHEN LEN(@NEWValue)<7
      --    THEN REPLICATE('0',7-LEN(@newValue))
        --  ELSE ''
       --END +
      -- @NEWValue
--Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
--select* from TONKHO
--delete from TONKHO
GO
/****** Object:  Trigger [UpdateBookQuatitySurvivalOnDelivery]    Script Date: 12/27/2013 18:46:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[UpdateBookQuatitySurvivalOnDelivery]
ON [dbo].[CHITIETHOADON]
AFTER INSERT
AS
BEGIN
	DECLARE @MaHD Varchar(15),@MaSach VARCHAR(15),@MaTonKho VARCHAR(15),@SoLuongBan int,@SoLuongTonDau int,@SoLuongTonCuoi int, @NgayHD smalldatetime;
	--Lấy thông tin sách từ phiếu nhập
	Select @MaSach = MaSach from INSERTED
	Select @SoLuongBan = SoLuong from INSERTED
	Select @MaHD = MaHD from INSERTED
	--
	Select @NgayHD = NgayHD from THONGTINCT_HOADON Where THONGTINCT_HOADON.MaHD = @MaHD
	Select @MaTonKho = MaTonKho from TONKHO where YEAR(ThangNam) = YEAR(@NgayHD) and MONTH(ThangNam) = MONTH(@NgayHD) and MaSach = @MaSach
	--
	if @MaTonKho is NOT NULL
	BEGIN
		Select @SoLuongTonCuoi = TonCuoi from TONKHO where MaTonKho = @MaTonKho
		Set @SoLuongTonCuoi = @SoLuongTonCuoi - @SoLuongBan
		Update TONKHO set TonCuoi = @SoLuongTonCuoi where MaTonKho = @MaTonKho
	END
	else
	BEGIN
		--Select @SoLuongTonDau = TonCuoi from TONKHO
		-- where (YEAR(ThangNam) = YEAR(@NgayNhap) and MONTH(ThangNam) = MONTH(@NgayNhap)- 1) or (YEAR(ThangNam) = YEAR(@NgayNhap) and MONTH(ThangNam) = MONTH(@NgayNhap)- 1)  and MaTonKho = @MaTonKho
		Set @SoLuongTonDau = (select Top 1 TonCuoi from TONKHO where MaSach = @MaSach order by MaTonKho desc)
		INSERT INTO TONKHO VALUES('TK0000000',@MaSach,@SoLuongTonDau,0,(@SoLuongTonDau - @SoLuongBan),@NgayHD)
	 END
END
--Lấy phần chuỗi số đằng sau TL rồi tăng lên 1 đơn vị
--SET @NEWValue= REPLACE(@MaxValue,'PN','')+1
-- Kiểm tra NEWValue nếu < 100
-- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 7
--SET @NEW_ID = 'PN'+
  --  CASE
    --   WHEN LEN(@NEWValue)<7
      --    THEN REPLICATE('0',7-LEN(@newValue))
        --  ELSE ''
       --END +
      -- @NEWValue
--Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
--select* from TONKHO
--delete from TONKHO
GO
/****** Object:  Table [dbo].[QUYDINH]    Script Date: 12/27/2013 18:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUYDINH](
	[SoLuongNhapToiThieu] [int] NULL,
	[SoTienNoToiDa] [int] NULL,
	[SoLuongTonToiThieuSauBan] [int] NULL,
	[SoLuongTonToiDaTruocNhap] [int] NULL,
	[SuDungQuyDinh4] [bit] NULL,
	[DoTuoiNhanVienToiThieu] [int] NULL,
	[DoTuoiNhanVienToiDa] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[QUYDINH] ([SoLuongNhapToiThieu], [SoTienNoToiDa], [SoLuongTonToiThieuSauBan], [SoLuongTonToiDaTruocNhap], [SuDungQuyDinh4], [DoTuoiNhanVienToiThieu], [DoTuoiNhanVienToiDa]) VALUES (0, 13, 0, 0, 1, 0, 0)
/****** Object:  Trigger [AutoIncrementAuthorId]    Script Date: 12/27/2013 18:46:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[AutoIncrementAuthorId]
ON [dbo].[TACGIA]
FOR INSERT
AS
BEGIN
DECLARE @MAXValue VARCHAR(15),@NEWValue VARCHAR(15),@NEW_ID VARCHAR(15), @OLD_ID VARCHAR(15);
--Lấy giá trị lớn nhất của UserID trong bảng tác giả
SELECT @MAXValue=MAX(MaTG) FROM TACGIA
--Lấy giá trị ID được chèn vào từ bên ngoài (bất kì, không quan trọng)
select @OLD_ID = MaTG from INSERTED
--Lấy phần chuỗi số đằng sau TG rồi tăng lên 1 đơn vị
SET @NEWValue= REPLACE(@MaxValue,'TG','')+1
-- Kiểm tra NEWValue nếu < 100
-- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 7
SET @NEW_ID = 'TG'+
    CASE
       WHEN LEN(@NEWValue)<7
          THEN REPLICATE('0',7-LEN(@newValue))
          ELSE ''
       END +
       @NEWValue
--Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
UPDATE TACGIA SET MaTG = @NEW_ID WHERE MaTG = @OLD_ID
END
GO
/****** Object:  Trigger [AutoIncrement]    Script Date: 12/27/2013 18:46:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[AutoIncrement]
ON [dbo].[THELOAI]
FOR INSERT
AS
BEGIN
DECLARE @MAXValue VARCHAR(15),@NEWValue VARCHAR(15),@NEW_ID VARCHAR(15), @OLD_ID VARCHAR(15);
--Lấy giá trị lớn nhất của UserID trong bảng Manager
SELECT @MAXValue=MAX(MaTL) FROM THELOAI
--Lấy giá trị ID được chèn vào từ bên ngoài (bất kì, không quan trọng)
select @OLD_ID = MaTL from INSERTED
--Lấy phần chuỗi số đằng sau TL rồi tăng lên 1 đơn vị
SET @NEWValue= REPLACE(@MaxValue,'TL','')+1
-- Kiểm tra NEWValue nếu < 100
-- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 7
SET @NEW_ID = 'TL'+
    CASE
       WHEN LEN(@NEWValue)<7
          THEN REPLICATE('0',7-LEN(@newValue))
          ELSE ''
       END +
       @NEWValue
--Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
UPDATE THELOAI SET MaTL = @NEW_ID WHERE MaTL = @OLD_ID
END
GO
/****** Object:  Trigger [AutoIncrementPublisherId]    Script Date: 12/27/2013 18:46:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[AutoIncrementPublisherId]
ON [dbo].[NHAXUATBAN]
FOR INSERT
AS
BEGIN
DECLARE @MAXValue VARCHAR(15),@NEWValue VARCHAR(15),@NEW_ID VARCHAR(15), @OLD_ID VARCHAR(15);
--Lấy giá trị lớn nhất của UserID trong bảng Manager
SELECT @MAXValue=MAX(MaNXB) FROM NHAXUATBAN
--Lấy giá trị ID được chèn vào từ bên ngoài (bất kì, không quan trọng)
select @OLD_ID = MaNXB from INSERTED
--Lấy phần chuỗi số đằng sau TL rồi tăng lên 1 đơn vị
SET @NEWValue= REPLACE(@MaxValue,'NXB','')+1
-- Kiểm tra NEWValue nếu < 100
-- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 7
SET @NEW_ID = 'NXB'+
    CASE
       WHEN LEN(@NEWValue)<7
          THEN REPLICATE('0',7-LEN(@newValue))
          ELSE ''
       END +
       @NEWValue
--Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
UPDATE NHAXUATBAN SET MaNXB = @NEW_ID WHERE MaNXB = @OLD_ID
END
GO
/****** Object:  Trigger [AutoIncrementCustomerId]    Script Date: 12/27/2013 18:46:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[AutoIncrementCustomerId]
ON [dbo].[KHACHHANG]
FOR INSERT
AS
BEGIN
DECLARE @MAXValue VARCHAR(15),@NEWValue VARCHAR(15),@NEW_ID VARCHAR(15), @OLD_ID VARCHAR(15);
--Lấy giá trị lớn nhất của UserID trong bảng Manager
SELECT @MAXValue=MAX(MaKH) FROM KHACHHANG
--Lấy giá trị ID được chèn vào từ bên ngoài (bất kì, không quan trọng)
select @OLD_ID = MaKH from INSERTED
--Lấy phần chuỗi số đằng sau TL rồi tăng lên 1 đơn vị
SET @NEWValue= REPLACE(@MaxValue,'KH','')+1
-- Kiểm tra NEWValue nếu < 100
-- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 7
SET @NEW_ID = 'KH'+
    CASE
       WHEN LEN(@NEWValue)<7
          THEN REPLICATE('0',7-LEN(@newValue))
          ELSE ''
       END +
       @NEWValue
--Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
UPDATE KHACHHANG SET MaKH = @NEW_ID WHERE MaKH = @OLD_ID
END
GO
/****** Object:  Trigger [AutoIncrementChargeId]    Script Date: 12/27/2013 18:46:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[AutoIncrementChargeId]
ON [dbo].[CHUCVU]
FOR INSERT
AS
BEGIN
DECLARE @MAXValue VARCHAR(15),@NEWValue VARCHAR(15),@NEW_ID VARCHAR(15), @OLD_ID VARCHAR(15);
--Lấy giá trị lớn nhất của UserID trong bảng Manager
SELECT @MAXValue=MAX(MaCV) FROM CHUCVU
--Lấy giá trị ID được chèn vào từ bên ngoài (bất kì, không quan trọng)
select @OLD_ID = MaCV from INSERTED
--Lấy phần chuỗi số đằng sau TL rồi tăng lên 1 đơn vị
SET @NEWValue= REPLACE(@MaxValue,'CV','')+1
-- Kiểm tra NEWValue nếu < 100
-- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 7
SET @NEW_ID = 'CV'+
    CASE
       WHEN LEN(@NEWValue)<7
          THEN REPLICATE('0',7-LEN(@newValue))
          ELSE ''
       END +
       @NEWValue
--Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
UPDATE CHUCVU SET MaCV = @NEW_ID WHERE MaCV = @OLD_ID
END
GO
/****** Object:  Table [dbo].[CONGNO]    Script Date: 12/27/2013 18:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONGNO](
	[MaCongNo] [nvarchar](20) NOT NULL,
	[MaKH] [nvarchar](20) NULL,
	[NoDau] [money] NULL,
	[NoCuoi] [money] NULL,
	[PhatSinh] [money] NULL,
	[ThangNam] [date] NULL,
 CONSTRAINT [PK_CONGNO] PRIMARY KEY CLUSTERED 
(
	[MaCongNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUTHUTIEN]    Script Date: 12/27/2013 18:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTHUTIEN](
	[MaPhieuThu] [nvarchar](20) NOT NULL,
	[MaKH] [nvarchar](20) NULL,
	[MaNV] [nvarchar](20) NULL,
	[SoTienThu] [money] NULL,
	[NgayThu] [date] NULL,
 CONSTRAINT [PK_PHIEUTHUTIEN] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Trigger [AutoIncrementBookTitleId]    Script Date: 12/27/2013 18:46:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[AutoIncrementBookTitleId]
ON [dbo].[DAUSACH]
FOR INSERT
AS
BEGIN
DECLARE @MAXValue VARCHAR(15),@NEWValue VARCHAR(15),@NEW_ID VARCHAR(15), @OLD_ID VARCHAR(15);
--Lấy giá trị lớn nhất của UserID trong bảng Manager
SELECT @MAXValue=MAX(MaDauSach) FROM DAUSACH
--Lấy giá trị ID được chèn vào từ bên ngoài (bất kì, không quan trọng)
select @OLD_ID = MaDauSach from INSERTED
--Lấy phần chuỗi số đằng sau TL rồi tăng lên 1 đơn vị
SET @NEWValue= REPLACE(@MaxValue,'DS','')+1
-- Kiểm tra NEWValue nếu < 100
-- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 7
SET @NEW_ID = 'DS'+
    CASE
       WHEN LEN(@NEWValue)<7
          THEN REPLICATE('0',7-LEN(@newValue))
          ELSE ''
       END +
       @NEWValue
--Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
UPDATE DAUSACH SET MaDauSach = @NEW_ID WHERE MaDauSach = @OLD_ID
END
GO
/****** Object:  Trigger [AutoIncrementEmployeeId]    Script Date: 12/27/2013 18:46:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[AutoIncrementEmployeeId]
ON [dbo].[NHANVIEN]
FOR INSERT
AS
BEGIN
DECLARE @MAXValue VARCHAR(15),@NEWValue VARCHAR(15),@NEW_ID VARCHAR(15), @OLD_ID VARCHAR(15);
--Lấy giá trị lớn nhất của UserID trong bảng Manager
SELECT @MAXValue=MAX(MaNV) FROM NHANVIEN
--Lấy giá trị ID được chèn vào từ bên ngoài (bất kì, không quan trọng)
select @OLD_ID = MaNV from INSERTED
--Lấy phần chuỗi số đằng sau TL rồi tăng lên 1 đơn vị
SET @NEWValue= REPLACE(@MaxValue,'NV','')+1
-- Kiểm tra NEWValue nếu < 100
-- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 7
SET @NEW_ID = 'NV'+
    CASE
       WHEN LEN(@NEWValue)<7
          THEN REPLICATE('0',7-LEN(@newValue))
          ELSE ''
       END +
       @NEWValue
--Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
UPDATE NHANVIEN SET MaNV = @NEW_ID WHERE MaNV = @OLD_ID
END
GO
/****** Object:  Trigger [AutoIncrementDebitsId]    Script Date: 12/27/2013 18:46:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[AutoIncrementDebitsId]
ON [dbo].[CONGNO]
FOR INSERT
AS
BEGIN
DECLARE @MAXValue VARCHAR(15),@NEWValue VARCHAR(15),@NEW_ID VARCHAR(15), @OLD_ID VARCHAR(15);
--Lấy giá trị lớn nhất của MaSacg trong bảng SACH
SELECT @MAXValue=MAX(MaCongNo) FROM CONGNO
--Lấy giá trị ID được chèn vào từ bên ngoài (bất kì, không quan trọng)
select @OLD_ID = MaCongNo from INSERTED
--Lấy phần chuỗi số đằng sau SA rồi tăng lên 1 đơn vị
SET @NEWValue= REPLACE(@MaxValue,'CN','')+1
-- Kiểm tra NEWValue nếu < 100
-- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 7
SET @NEW_ID = 'CN'+
    CASE
       WHEN LEN(@NEWValue)<7
          THEN REPLICATE('0',7-LEN(@newValue))
          ELSE ''
       END +
       @NEWValue
--Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
UPDATE CONGNO SET MaCongNo = @NEW_ID WHERE MaCongNo = @OLD_ID
END
GO
/****** Object:  Trigger [AutoIncrementBookId]    Script Date: 12/27/2013 18:46:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[AutoIncrementBookId]
ON [dbo].[SACH]
FOR INSERT
AS
BEGIN
DECLARE @MAXValue VARCHAR(15),@NEWValue VARCHAR(15),@NEW_ID VARCHAR(15), @OLD_ID VARCHAR(15);
--Lấy giá trị lớn nhất của MaSacg trong bảng SACH
SELECT @MAXValue=MAX(MaSach) FROM SACH
--Lấy giá trị ID được chèn vào từ bên ngoài (bất kì, không quan trọng)
select @OLD_ID = MaSach from INSERTED
--Lấy phần chuỗi số đằng sau SA rồi tăng lên 1 đơn vị
SET @NEWValue= REPLACE(@MaxValue,'SA','')+1
-- Kiểm tra NEWValue nếu < 100
-- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 7
SET @NEW_ID = 'SA'+
    CASE
       WHEN LEN(@NEWValue)<7
          THEN REPLICATE('0',7-LEN(@newValue))
          ELSE ''
       END +
       @NEWValue
--Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
UPDATE SACH SET MaSach = @NEW_ID WHERE MaSach = @OLD_ID
END
	select DISTINCT THONGTINSACH.MaSach,THONGTINSACH.MaDauSach,THONGTINSACH.TenSach,DS.NhomTG,THONGTINSACH.TenTL,THONGTINSACH.NamXB,THONGTINSACH.MaNXB,THONGTINSACH.TenNXB,THONGTINSACH.GiaNhap,THONGTINSACH.SoLuong from THONGTINSACH inner join
(select MaDauSach,
 STUFF((Select ('- ') + TenTG from THONGTINDAUSACH DS2 where  DS1.MaDauSach = DS2.MaDauSach for XML PATH('')),1,1, '')
  NhomTG from THONGTINDAUSACH DS1 Group by MaDauSach) as DS on THONGTINSACH.MaDauSach = DS.MaDauSach
  select MaDauSach,
 STUFF((Select ('- ') + TenTG from THONGTINDAUSACH DS2 where  DS1.MaDauSach = DS2.MaDauSach for XML PATH('')),1,1, '')
  NhomTG from THONGTINDAUSACH DS1 Group by MaDauSach
  
  
select* from CHITIETPHIEUNHAP

select*  from KHACHHANG
where DiaChi like '%%'
GO
/****** Object:  Trigger [AutoIncrementReceptsId]    Script Date: 12/27/2013 18:46:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[AutoIncrementReceptsId]
ON [dbo].[PHIEUTHUTIEN]
FOR INSERT
AS
BEGIN
DECLARE @MAXValue VARCHAR(15),@NEWValue VARCHAR(15),@NEW_ID VARCHAR(15), @OLD_ID VARCHAR(15);
--Lấy giá trị lớn nhất của MaPhieuThu trong bảng PHIEUTHUTIEN
SELECT @MAXValue=MAX(MaPhieuThu) FROM PHIEUTHUTIEN
--Lấy giá trị ID được chèn vào từ bên ngoài (bất kì, không quan trọng)
select @OLD_ID = MaPhieuThu from INSERTED
--Lấy phần chuỗi số đằng sau TL rồi tăng lên 1 đơn vị
SET @NEWValue= REPLACE(@MaxValue,'PT','')+1
-- Kiểm tra NEWValue nếu < 100
-- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 7
SET @NEW_ID = 'PT'+
    CASE
       WHEN LEN(@NEWValue)<7
          THEN REPLICATE('0',7-LEN(@newValue))
          ELSE ''
       END +
       @NEWValue
--Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
UPDATE PHIEUTHUTIEN SET MaPhieuThu = @NEW_ID WHERE MaPhieuThu = @OLD_ID
END
GO
/****** Object:  Trigger [AutoIncrementDeliveryNoteId]    Script Date: 12/27/2013 18:46:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[AutoIncrementDeliveryNoteId]
ON [dbo].[HOADON]
FOR INSERT
AS
BEGIN
DECLARE @MAXValue VARCHAR(15),@NEWValue VARCHAR(15),@NEW_ID VARCHAR(15), @OLD_ID VARCHAR(15);
--Lấy giá trị lớn nhất của UserID trong bảng Manager
SELECT @MAXValue=MAX(MaHD) FROM HOADON
--Lấy giá trị ID được chèn vào từ bên ngoài (bất kì, không quan trọng)
select @OLD_ID = MaHD from INSERTED
--Lấy phần chuỗi số đằng sau TL rồi tăng lên 1 đơn vị
SET @NEWValue= REPLACE(@MaxValue,'HD','')+1
-- Kiểm tra NEWValue nếu < 100
-- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 7
SET @NEW_ID = 'HD'+
    CASE
       WHEN LEN(@NEWValue)<7
          THEN REPLICATE('0',7-LEN(@newValue))
          ELSE ''
       END +
       @NEWValue
--Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
UPDATE HOADON SET MaHD = @NEW_ID WHERE MaHD = @OLD_ID
END
GO
/****** Object:  Trigger [AutoIncrementBookImportId]    Script Date: 12/27/2013 18:46:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[AutoIncrementBookImportId]
ON [dbo].[PHIEUNHAPSACH]
FOR INSERT
AS
BEGIN
DECLARE @MAXValue VARCHAR(15),@NEWValue VARCHAR(15),@NEW_ID VARCHAR(15), @OLD_ID VARCHAR(15);
--Lấy giá trị lớn nhất của UserID trong bảng Manager
SELECT @MAXValue=MAX(MaPhieuNhap) FROM PHIEUNHAPSACH
--Lấy giá trị ID được chèn vào từ bên ngoài (bất kì, không quan trọng)
select @OLD_ID = MaPhieuNhap from INSERTED
--Lấy phần chuỗi số đằng sau TL rồi tăng lên 1 đơn vị
SET @NEWValue= REPLACE(@MaxValue,'PN','')+1
-- Kiểm tra NEWValue nếu < 100
-- Nếu <100, thêm vào số 0 sao cho NEWValue có độ dài = 7
SET @NEW_ID = 'PN'+
    CASE
       WHEN LEN(@NEWValue)<7
          THEN REPLICATE('0',7-LEN(@newValue))
          ELSE ''
       END +
       @NEWValue
--Thay thế giá trị Id từ bên ngoài bằng Id vừa được tạo
UPDATE PHIEUNHAPSACH SET MaPhieuNhap = @NEW_ID WHERE MaPhieuNhap = @OLD_ID
END
GO
/****** Object:  ForeignKey [FK_CHITIETHOADON_HOADON]    Script Date: 12/27/2013 18:46:52 ******/
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_HOADON] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_HOADON]
GO
/****** Object:  ForeignKey [FK_CHITIETHOADON_SACH]    Script Date: 12/27/2013 18:46:52 ******/
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_SACH]
GO
/****** Object:  ForeignKey [FK_CHITIETPHIEUNHAP_PHIEUNHAPSACH]    Script Date: 12/27/2013 18:46:52 ******/
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUNHAP_PHIEUNHAPSACH] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [FK_CHITIETPHIEUNHAP_PHIEUNHAPSACH]
GO
/****** Object:  ForeignKey [FK_CHITIETPHIEUNHAP_SACH]    Script Date: 12/27/2013 18:46:52 ******/
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUNHAP_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [FK_CHITIETPHIEUNHAP_SACH]
GO
/****** Object:  ForeignKey [FK_CHITIETTACGIA_DAUSACH]    Script Date: 12/27/2013 18:46:52 ******/
ALTER TABLE [dbo].[CHITIETTACGIA]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETTACGIA_DAUSACH] FOREIGN KEY([MaDauSach])
REFERENCES [dbo].[DAUSACH] ([MaDauSach])
GO
ALTER TABLE [dbo].[CHITIETTACGIA] CHECK CONSTRAINT [FK_CHITIETTACGIA_DAUSACH]
GO
/****** Object:  ForeignKey [FK_CHITIETTACGIA_TACGIA1]    Script Date: 12/27/2013 18:46:52 ******/
ALTER TABLE [dbo].[CHITIETTACGIA]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETTACGIA_TACGIA1] FOREIGN KEY([MaTG])
REFERENCES [dbo].[TACGIA] ([MaTG])
GO
ALTER TABLE [dbo].[CHITIETTACGIA] CHECK CONSTRAINT [FK_CHITIETTACGIA_TACGIA1]
GO
/****** Object:  ForeignKey [FK_CONGNO_KHACHHANG]    Script Date: 12/27/2013 18:46:52 ******/
ALTER TABLE [dbo].[CONGNO]  WITH CHECK ADD  CONSTRAINT [FK_CONGNO_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[CONGNO] CHECK CONSTRAINT [FK_CONGNO_KHACHHANG]
GO
/****** Object:  ForeignKey [FK_DAUSACH_THELOAI]    Script Date: 12/27/2013 18:46:52 ******/
ALTER TABLE [dbo].[DAUSACH]  WITH CHECK ADD  CONSTRAINT [FK_DAUSACH_THELOAI] FOREIGN KEY([MaTL])
REFERENCES [dbo].[THELOAI] ([MaTL])
GO
ALTER TABLE [dbo].[DAUSACH] CHECK CONSTRAINT [FK_DAUSACH_THELOAI]
GO
/****** Object:  ForeignKey [FK_HOADON_KHACHHANG]    Script Date: 12/27/2013 18:46:52 ******/
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG]
GO
/****** Object:  ForeignKey [FK_HOADON_NHANVIEN]    Script Date: 12/27/2013 18:46:52 ******/
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_NHANVIEN]
GO
/****** Object:  ForeignKey [FK_NHANVIEN_CHUCVU]    Script Date: 12/27/2013 18:46:52 ******/
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_CHUCVU] FOREIGN KEY([MaCV])
REFERENCES [dbo].[CHUCVU] ([MaCV])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_CHUCVU]
GO
/****** Object:  ForeignKey [FK_PHIEUNHAPSACH_NHANVIEN]    Script Date: 12/27/2013 18:46:52 ******/
ALTER TABLE [dbo].[PHIEUNHAPSACH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAPSACH_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUNHAPSACH] CHECK CONSTRAINT [FK_PHIEUNHAPSACH_NHANVIEN]
GO
/****** Object:  ForeignKey [FK_PHIEUTHUTIEN_KHACHHANG]    Script Date: 12/27/2013 18:46:52 ******/
ALTER TABLE [dbo].[PHIEUTHUTIEN]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHUTIEN_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[PHIEUTHUTIEN] CHECK CONSTRAINT [FK_PHIEUTHUTIEN_KHACHHANG]
GO
/****** Object:  ForeignKey [FK_PHIEUTHUTIEN_NHANVIEN]    Script Date: 12/27/2013 18:46:52 ******/
ALTER TABLE [dbo].[PHIEUTHUTIEN]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHUTIEN_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUTHUTIEN] CHECK CONSTRAINT [FK_PHIEUTHUTIEN_NHANVIEN]
GO
/****** Object:  ForeignKey [FK_SACH_DAUSACH]    Script Date: 12/27/2013 18:46:52 ******/
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_DAUSACH] FOREIGN KEY([MaDauSach])
REFERENCES [dbo].[DAUSACH] ([MaDauSach])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_DAUSACH]
GO
/****** Object:  ForeignKey [FK_SACH_NHAXUATBAN]    Script Date: 12/27/2013 18:46:52 ******/
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_NHAXUATBAN] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NHAXUATBAN] ([MaNXB])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_NHAXUATBAN]
GO
/****** Object:  ForeignKey [FK_TONKHO_SACH]    Script Date: 12/27/2013 18:46:52 ******/
ALTER TABLE [dbo].[TONKHO]  WITH CHECK ADD  CONSTRAINT [FK_TONKHO_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[TONKHO] CHECK CONSTRAINT [FK_TONKHO_SACH]
GO
