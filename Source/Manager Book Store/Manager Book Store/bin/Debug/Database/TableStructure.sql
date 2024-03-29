/****** Object:  Table [dbo].[CHUCVU]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Table [dbo].[PHIEUNHAPSACH]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Table [dbo].[CHITIETPHIEUNHAP]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Table [dbo].[THELOAI]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Table [dbo].[DAUSACH]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Table [dbo].[TACGIA]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Table [dbo].[CHITIETTACGIA]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Table [dbo].[SACH]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Table [dbo].[TONKHO]    Script Date: 04/01/2014 01:09:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TONKHO](
	[MaTonKho] [nvarchar](20) NOT NULL,
	[MaSach] [nvarchar](20) NULL,
	[TonDau] [int] NULL,
	[PhatSinh] [int] NULL,
	[TonCuoi] [int] NULL,
	[ThangNam] [date] NULL,
 CONSTRAINT [PK_TONKHO] PRIMARY KEY CLUSTERED 
(
	[MaTonKho] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Trigger [UpdateBookQuatitySurvival]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Table [dbo].[HOADON]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Trigger [UpdateBookQuatitySurvivalOnDelivery]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Trigger [AutoIncrementSurvivalId]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Trigger [UpdateBookImportId]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Trigger [UpdateBookExportId]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Table [dbo].[QUYDINH]    Script Date: 04/01/2014 01:09:18 ******/
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
	[DoTuoiNhanVienToiDa] [int] NULL,
	[MucLoiNhuan] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHANQUYEN]    Script Date: 04/01/2014 01:09:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHANQUYEN](
	[MaCV] [nvarchar](20) NOT NULL,
	[ThietLapHeThong] [bit] NULL,
	[ThayDoiQuyDinh] [bit] NULL,
	[QuanLySach] [bit] NULL,
	[QuanLyNhanVien] [bit] NULL,
	[QuanLyKhachHang] [bit] NULL,
	[LapPhieuNhapSach] [bit] NULL,
	[LapHoaDonBanSach] [bit] NULL,
	[LapPhieuThuTien] [bit] NULL,
	[TraCuuSach] [bit] NULL,
	[TraCuuNhanVien] [bit] NULL,
	[TraCuuHoaDon] [bit] NULL,
	[TraCuuKhachHang] [bit] NULL,
	[LapBaoCaoThang] [bit] NULL,
 CONSTRAINT [PK_PHANQUYEN] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Trigger [AutoIncrementAuthorId]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Trigger [AutoIncrement]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Trigger [AutoIncrementPublisherId]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Trigger [AutoIncrementCustomerId]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Trigger [AutoIncrementChargeId]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Table [dbo].[CONGNO]    Script Date: 04/01/2014 01:09:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONGNO](
	[MaCongNo] [nvarchar](20) NOT NULL,
	[MaKH] [nvarchar](20) NULL,
	[NoDau] [money] NULL,
	[PhatSinh] [money] NULL,
	[NoCuoi] [money] NULL,
	[ThangNam] [date] NULL,
 CONSTRAINT [PK_CONGNO] PRIMARY KEY CLUSTERED 
(
	[MaCongNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUTHUTIEN]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Trigger [AutoIncrementBookTitleId]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Trigger [AutoIncrementEmployeeId]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Trigger [AutoIncrementDebitsId]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Trigger [AutoIncrementBookId]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Trigger [AutoIncrementReceptsId]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Trigger [AutoIncrementDeliveryNoteId]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  Trigger [AutoIncrementBookImportId]    Script Date: 04/01/2014 01:09:18 ******/
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
/****** Object:  ForeignKey [FK_CHITIETHOADON_HOADON]    Script Date: 04/01/2014 01:09:18 ******/
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_HOADON] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_HOADON]
GO
/****** Object:  ForeignKey [FK_CHITIETHOADON_SACH]    Script Date: 04/01/2014 01:09:18 ******/
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_SACH]
GO
/****** Object:  ForeignKey [FK_CHITIETPHIEUNHAP_PHIEUNHAPSACH]    Script Date: 04/01/2014 01:09:18 ******/
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUNHAP_PHIEUNHAPSACH] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [FK_CHITIETPHIEUNHAP_PHIEUNHAPSACH]
GO
/****** Object:  ForeignKey [FK_CHITIETPHIEUNHAP_SACH]    Script Date: 04/01/2014 01:09:18 ******/
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUNHAP_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [FK_CHITIETPHIEUNHAP_SACH]
GO
/****** Object:  ForeignKey [FK_CHITIETTACGIA_DAUSACH]    Script Date: 04/01/2014 01:09:18 ******/
ALTER TABLE [dbo].[CHITIETTACGIA]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETTACGIA_DAUSACH] FOREIGN KEY([MaDauSach])
REFERENCES [dbo].[DAUSACH] ([MaDauSach])
GO
ALTER TABLE [dbo].[CHITIETTACGIA] CHECK CONSTRAINT [FK_CHITIETTACGIA_DAUSACH]
GO
/****** Object:  ForeignKey [FK_CHITIETTACGIA_TACGIA1]    Script Date: 04/01/2014 01:09:18 ******/
ALTER TABLE [dbo].[CHITIETTACGIA]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETTACGIA_TACGIA1] FOREIGN KEY([MaTG])
REFERENCES [dbo].[TACGIA] ([MaTG])
GO
ALTER TABLE [dbo].[CHITIETTACGIA] CHECK CONSTRAINT [FK_CHITIETTACGIA_TACGIA1]
GO
/****** Object:  ForeignKey [FK_CONGNO_KHACHHANG]    Script Date: 04/01/2014 01:09:18 ******/
ALTER TABLE [dbo].[CONGNO]  WITH CHECK ADD  CONSTRAINT [FK_CONGNO_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[CONGNO] CHECK CONSTRAINT [FK_CONGNO_KHACHHANG]
GO
/****** Object:  ForeignKey [FK_DAUSACH_THELOAI]    Script Date: 04/01/2014 01:09:18 ******/
ALTER TABLE [dbo].[DAUSACH]  WITH CHECK ADD  CONSTRAINT [FK_DAUSACH_THELOAI] FOREIGN KEY([MaTL])
REFERENCES [dbo].[THELOAI] ([MaTL])
GO
ALTER TABLE [dbo].[DAUSACH] CHECK CONSTRAINT [FK_DAUSACH_THELOAI]
GO
/****** Object:  ForeignKey [FK_HOADON_KHACHHANG]    Script Date: 04/01/2014 01:09:18 ******/
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG]
GO
/****** Object:  ForeignKey [FK_HOADON_NHANVIEN]    Script Date: 04/01/2014 01:09:18 ******/
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_NHANVIEN]
GO
/****** Object:  ForeignKey [FK_NHANVIEN_CHUCVU]    Script Date: 04/01/2014 01:09:18 ******/
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_CHUCVU] FOREIGN KEY([MaCV])
REFERENCES [dbo].[CHUCVU] ([MaCV])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_CHUCVU]
GO
/****** Object:  ForeignKey [FK_PHANQUYEN_CHUCVU]    Script Date: 04/01/2014 01:09:18 ******/
ALTER TABLE [dbo].[PHANQUYEN]  WITH CHECK ADD  CONSTRAINT [FK_PHANQUYEN_CHUCVU] FOREIGN KEY([MaCV])
REFERENCES [dbo].[CHUCVU] ([MaCV])
GO
ALTER TABLE [dbo].[PHANQUYEN] CHECK CONSTRAINT [FK_PHANQUYEN_CHUCVU]
GO
/****** Object:  ForeignKey [FK_PHIEUNHAPSACH_NHANVIEN]    Script Date: 04/01/2014 01:09:18 ******/
ALTER TABLE [dbo].[PHIEUNHAPSACH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAPSACH_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUNHAPSACH] CHECK CONSTRAINT [FK_PHIEUNHAPSACH_NHANVIEN]
GO
/****** Object:  ForeignKey [FK_PHIEUTHUTIEN_KHACHHANG]    Script Date: 04/01/2014 01:09:18 ******/
ALTER TABLE [dbo].[PHIEUTHUTIEN]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHUTIEN_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[PHIEUTHUTIEN] CHECK CONSTRAINT [FK_PHIEUTHUTIEN_KHACHHANG]
GO
/****** Object:  ForeignKey [FK_PHIEUTHUTIEN_NHANVIEN]    Script Date: 04/01/2014 01:09:18 ******/
ALTER TABLE [dbo].[PHIEUTHUTIEN]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHUTIEN_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUTHUTIEN] CHECK CONSTRAINT [FK_PHIEUTHUTIEN_NHANVIEN]
GO
/****** Object:  ForeignKey [FK_SACH_DAUSACH]    Script Date: 04/01/2014 01:09:18 ******/
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_DAUSACH] FOREIGN KEY([MaDauSach])
REFERENCES [dbo].[DAUSACH] ([MaDauSach])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_DAUSACH]
GO
/****** Object:  ForeignKey [FK_SACH_NHAXUATBAN]    Script Date: 04/01/2014 01:09:18 ******/
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_NHAXUATBAN] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NHAXUATBAN] ([MaNXB])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_NHAXUATBAN]
GO
/****** Object:  ForeignKey [FK_TONKHO_SACH]    Script Date: 04/01/2014 01:09:18 ******/
ALTER TABLE [dbo].[TONKHO]  WITH CHECK ADD  CONSTRAINT [FK_TONKHO_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[TONKHO] CHECK CONSTRAINT [FK_TONKHO_SACH]
GO
