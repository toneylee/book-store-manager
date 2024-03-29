USE [master]
GO
/****** Object:  Database [MANAGERBOOKSTORE]    Script Date: 12/22/2013 10:31:50 ******/
CREATE DATABASE [MANAGERBOOKSTORE] ON  PRIMARY 
( NAME = N'MANAGERBOOKSTORE', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\MANAGERBOOKSTORE.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MANAGERBOOKSTORE_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\MANAGERBOOKSTORE_log.LDF' , SIZE = 768KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MANAGERBOOKSTORE].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET ANSI_NULLS OFF
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET ANSI_PADDING OFF
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET ARITHABORT OFF
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET AUTO_CLOSE ON
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET  ENABLE_BROKER
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET  READ_WRITE
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET RECOVERY SIMPLE
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET  MULTI_USER
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [MANAGERBOOKSTORE] SET DB_CHAINING OFF
GO
USE [MANAGERBOOKSTORE]
GO
/****** Object:  FullTextCatalog [FullCatalog]    Script Date: 12/22/2013 10:31:50 ******/
CREATE FULLTEXT CATALOG [FullCatalog]AS DEFAULT
AUTHORIZATION [dbo]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 12/22/2013 10:31:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [nvarchar](20) NOT NULL,
	[TenKH] [nvarchar](255) NULL,
	[GioiTinh] [smallint] NULL,
	[NgaySinh] [date] NULL,
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
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 12/22/2013 10:31:52 ******/
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
/****** Object:  Table [dbo].[THELOAI]    Script Date: 12/22/2013 10:31:52 ******/
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
/****** Object:  Table [dbo].[TACGIA]    Script Date: 12/22/2013 10:31:52 ******/
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
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 12/22/2013 10:31:52 ******/
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
/****** Object:  StoredProcedure [dbo].[UpdateAuthorDataToDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateAuthorDataToDatabase]

(
	@MaTG nvarchar(20),
	@TenTG nvarchar(255),
	@DiaChi nvarchar(255)
	)
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
update TACGIA set TenTG = @TenTG, DiaChi = @DiaChi where MaTG = @MaTG
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomerDataToDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCustomerDataToDatabase]
	(
	@MaKH  nvarchar(20),
	@TenKH nvarchar(255),
	@GioiTinh nvarchar(5),
	@NgaySinh smalldatetime,
	@DiaChi nvarchar(255),
	@Email nvarchar(255),
	@SoDienThoai nvarchar(255),
	@TienNo money
	)
	AS
	Update KHACHHANG set TenKH = @TenKH, GioiTinh = @GioiTinh,NgaySinh = @NgaySinh,SoDienThoai = @SoDienThoai,Email = @Email,DiaChi = @DiaChi,TienNo = @TienNo where MaKH = @MaKH

	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/

	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[UpdateChargeDataToDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateChargeDataToDatabase]
	(
	@MaCV nvarchar(20),
	@TenCV nvarchar(255)
	)
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
update CHUCVU set TenCV = @TenCV where MaCV = @MaCV
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[LookAtCustomerDataFromDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LookAtCustomerDataFromDatabase]
	(
	@TenKH nvarchar(255)
	)
	AS
	Select* from KHACHHANG where TenKH like '%'+@TenKH+'%'
	/*Select* from THELOAI where contains(TenTL,@TenTL)*/
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/

	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[LookAtChargeDataFromDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LookAtChargeDataFromDatabase]
	(
	@TenCV nvarchar(255)
	)
	AS
	Select* from CHUCVU where TenCV like '%'+@TenCV+'%'
	/*Select* from THELOAI where contains(TenTL,@TenTL)*/
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/

	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[LookAtBookGenreDataFromDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LookAtBookGenreDataFromDatabase]
	(
	@TenTL nvarchar(100)
	)
	AS
	Select* from THELOAI where TenTL like '%'+@TenTL+'%'
	/*Select* from THELOAI where contains(TenTL,@TenTL)*/
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/

	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[LookAtAuthorDataFromDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LookAtAuthorDataFromDatabase]
	(
	@TenTG nvarchar(255)
	)
	AS
	Select* from TACGIA where TenTG like '%'+@TenTG+'%'
	/*Select* from THELOAI where contains(TenTL,@TenTL)*/
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/

	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/22/2013 10:31:58 ******/
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
/****** Object:  StoredProcedure [dbo].[LookAtPublisherDataFromDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LookAtPublisherDataFromDatabase]
	(
	@TenNXB nvarchar(255)
	)
	AS
	Select* from NHAXUATBAN where TenNXB like '%'+@TenNXB+'%'
	/*Select* from THELOAI where contains(TenTL,@TenTL)*/
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/

	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[AddBookChargeToDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddBookChargeToDatabase]
	(
	@MaCV  nvarchar(20),
	@TenCV nvarchar(255)
	)
	AS
	insert into CHUCVU values(@MaCV,@TenCV)

	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/

	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[AddBookGenreDataToDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddBookGenreDataToDatabase]
	(
	@MaTL  nvarchar(20),
	@TenTL nvarchar(255)
	)
	AS
	insert into THELOAI values(@MaTL,@TenTL)

	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/

	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[AddCustomerDataToDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddCustomerDataToDatabase]
	(
	@MaKH  nvarchar(20),
	@TenKH nvarchar(255),
	@GioiTinh nvarchar(5),
	@NgaySinh smalldatetime,
	@DiaChi nvarchar(255),
	@Email nvarchar(255),
	@SoDienThoai nvarchar(255),
	@TienNo money
	)
	AS
	insert into KHACHHANG values(@MaKH,@TenKH,@GioiTinh,@NgaySinh,@SoDienThoai,@Email,@DiaChi,@TienNo)

	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/

	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[AddPublisherDataToDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddPublisherDataToDatabase]
	(
	@MaNXB nvarchar(20),
	@TenNXB nvarchar(255),
	@DiaChi nvarchar(255)
	)
	AS
	insert into NHAXUATBAN values(@MaNXB,@TenNXB,@DiaChi)

	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/

	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  Trigger [AutoIncrementAuthorId]    Script Date: 12/22/2013 10:32:00 ******/
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
/****** Object:  Trigger [AutoIncrement]    Script Date: 12/22/2013 10:32:00 ******/
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
/****** Object:  StoredProcedure [dbo].[AddAuthorDataToDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddAuthorDataToDatabase]
	(
	@MaTG nvarchar(20),
	@TenTG nvarchar(255),
	@DiaChi nvarchar(255)
	)
	AS
	insert into TACGIA values(@MaTG,@TenTG,@DiaChi)

	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/

	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  Trigger [AutoIncrementPublisherId]    Script Date: 12/22/2013 10:32:00 ******/
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
/****** Object:  StoredProcedure [dbo].[DeleteAuthorDataToDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteAuthorDataToDatabase]
(@MaTG nvarchar(20)
)	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
delete from TACGIA where MaTG =@MaTG
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  Table [dbo].[DAUSACH]    Script Date: 12/22/2013 10:31:58 ******/
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
/****** Object:  Table [dbo].[CONGNO]    Script Date: 12/22/2013 10:31:58 ******/
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
/****** Object:  StoredProcedure [dbo].[DeleteBookGenreDataToDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteBookGenreDataToDatabase]
(@MaTL nvarchar(20)
)	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
delete from THELOAI where MaTL =@MaTL
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[DeleteCustomerDataToDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteCustomerDataToDatabase]
	
	@MaKH  nvarchar(20)
	
AS
	Delete from KHACHHANG where MaKH = @MaKH
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[DeleteChargeDataToDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteChargeDataToDatabase]
(@MaCV nvarchar(20)
)	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
delete from CHUCVU where MaCV =@MaCV
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[GetAuthorDataFromDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAuthorDataFromDatabase]
AS
BEGIN
select * from TACGIA
	/* SET NOCOUNT ON */
	END
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[DeletePublisherDataToDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeletePublisherDataToDatabase]
(
	@MaNXB nvarchar(20)
)	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
delete from NHAXUATBAN where MaNXB =@MaNXB
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[GetBookGenreDataFromDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetBookGenreDataFromDatabase]
AS
BEGIN
select * from THELOAI
	/* SET NOCOUNT ON */
	END
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[GetPublisherDataFromDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPublisherDataFromDatabase]
AS
BEGIN
select * from NHAXUATBAN
	/* SET NOCOUNT ON */
	END
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[GetCustomerDataFromDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCustomerDataFromDatabase]
as
select * from KHACHHANG
GO
/****** Object:  StoredProcedure [dbo].[GetChargeDataFromDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetChargeDataFromDatabase]
AS
BEGIN
select * from CHUCVU
	/* SET NOCOUNT ON */
	END
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[UpdateBookGenreDataToDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateBookGenreDataToDatabase]
	(
	@MaTL nvarchar(20),
	@TenTL nvarchar(100)
	)
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
update THELOAI set TenTL = @TenTL where MaTL = @MaTL
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[UpdatePublisherDataToDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdatePublisherDataToDatabase]
	(
	@MaNXB nvarchar(20),
	@TenNXB nvarchar(255),
	@DiaChi nvarchar(255)
	)
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
update NHAXUATBAN set TenNXB = @TenNXB, DiaChi = @DiaChi where MaNXB = @MaNXB
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[UpdateEmployeeDataToDatabase]    Script Date: 12/22/2013 10:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateEmployeeDataToDatabase]
	(
	@MaNV  nvarchar(20),
	@TenNV nvarchar(255),
	@GioiTinh nvarchar(5),
	@NgaySinh smalldatetime,
	@DiaChi nvarchar(255),
	@Email nvarchar(255),
	@SoDienThoai nvarchar(255),
	@NgayVaoLam smalldatetime,
	@TenDangNhap nvarchar(255),
	@MatKhau nvarchar(255),
	@MaCV nvarchar(20)
	)
	AS
	Update NHANVIEN set TenNV = @TenNV,GioiTinh = @GioiTinh,NgaySinh = @NgaySinh,Email = @Email
	,DienThoai = @SoDienThoai,DiaChi = @DiaChi,NgayVaoLam = @NgayVaoLam,MaCV = @MaCV,UserName = @TenDangNhap,PassWord = @MatKhau
	where MaNV = @MaNV

	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/

	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 12/22/2013 10:31:58 ******/
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
/****** Object:  StoredProcedure [dbo].[GetBookTitlesMaxIdFromDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetBookTitlesMaxIdFromDatabase]
AS
	Select Max(MaDauSach) from DAUSACH
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[DeleteEmployeeDataToDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteEmployeeDataToDatabase]
	(
	@MaNV  nvarchar(20)
	)
	AS
	Delete from NHANVIEN where MaNV = @MaNV

	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/

	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[DeleteBookTitlesDataToDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteBookTitlesDataToDatabase]
(@MaDauSach nvarchar(20)
)	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
delete from DAUSACH where MaDauSach =@MaDauSach
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  Trigger [AutoIncrementEmployeeId]    Script Date: 12/22/2013 10:32:00 ******/
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
/****** Object:  Trigger [AutoIncrementBookTitleId]    Script Date: 12/22/2013 10:32:00 ******/
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
/****** Object:  StoredProcedure [dbo].[AddEmployeeDataToDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddEmployeeDataToDatabase]
	(
	@MaNV  nvarchar(20),
	@TenNV nvarchar(255),
	@GioiTinh nvarchar(5),
	@NgaySinh smalldatetime,
	@DiaChi nvarchar(255),
	@Email nvarchar(255),
	@SoDienThoai nvarchar(255),
	@NgayVaoLam smalldatetime,
	@TenDangNhap nvarchar(255),
	@MatKhau nvarchar(255),
	@MaCV nvarchar(20)
	)
	AS
	insert into NHANVIEN values(@MaNV,@TenNV,@GioiTinh,@NgaySinh,@Email,@SoDienThoai,@DiaChi,@NgayVaoLam,@MaCV,@TenDangNhap,@MatKhau)

	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/

	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[AddBookTitlesDataToDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddBookTitlesDataToDatabase]
	(
	@MaDauSach nvarchar(20),
	@MaTL nvarchar(20),
	@TenDauSach nvarchar(100)
	)
	AS
	insert into DAUSACH values(@MaDauSach,@TenDauSach,@MaTL)

	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/

	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  Table [dbo].[CHITIETTACGIA]    Script Date: 12/22/2013 10:31:58 ******/
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
/****** Object:  Table [dbo].[SACH]    Script Date: 12/22/2013 10:31:58 ******/
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
INSERT [dbo].[SACH] ([MaSach], [MaDauSach], [MaNXB], [NamXB], [GiaNhap], [SoLuong]) VALUES (N'SA0000003', N'DS0000004', N'NXB0000001', 1993, 0.0000, 0)
INSERT [dbo].[SACH] ([MaSach], [MaDauSach], [MaNXB], [NamXB], [GiaNhap], [SoLuong]) VALUES (N'SA0000004', N'DS0000001', N'NXB0000002', 1993, 0.0000, 0)
INSERT [dbo].[SACH] ([MaSach], [MaDauSach], [MaNXB], [NamXB], [GiaNhap], [SoLuong]) VALUES (N'SA0000005', N'DS0000004', N'NXB0000002', 1993, 0.0000, 0)
/****** Object:  Table [dbo].[PHIEUTHUTIEN]    Script Date: 12/22/2013 10:31:58 ******/
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
/****** Object:  Table [dbo].[PHIEUNHAPSACH]    Script Date: 12/22/2013 10:31:58 ******/
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
/****** Object:  StoredProcedure [dbo].[LookAtEmployeeDataFromDatabase]    Script Date: 12/22/2013 10:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LookAtEmployeeDataFromDatabase]
	(
	@TenNV nvarchar(255)
	)
	AS
	Select* from NHANVIEN where TenNV like '%'+@TenNV+'%'
	/*Select* from THELOAI where contains(TenTL,@TenTL)*/
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/

	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  View [dbo].[THONGTINNHANVIEN]    Script Date: 12/22/2013 10:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[THONGTINNHANVIEN]
AS
SELECT        dbo.CHUCVU.TenCV, dbo.CHUCVU.MaCV, dbo.NHANVIEN.MaNV, dbo.NHANVIEN.TenNV, dbo.NHANVIEN.GioiTinh, dbo.NHANVIEN.NgaySinh, dbo.NHANVIEN.Email, 
                         dbo.NHANVIEN.DienThoai, dbo.NHANVIEN.DiaChi, dbo.NHANVIEN.NgayVaoLam, dbo.NHANVIEN.UserName, dbo.NHANVIEN.Password
FROM            dbo.CHUCVU INNER JOIN
                         dbo.NHANVIEN ON dbo.CHUCVU.MaCV = dbo.NHANVIEN.MaCV
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "CHUCVU"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 101
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "NHANVIEN"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 135
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'THONGTINNHANVIEN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'THONGTINNHANVIEN'
GO
/****** Object:  StoredProcedure [dbo].[UpdateBookTitlesDataToDatabase]    Script Date: 12/22/2013 10:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[UpdateBookTitlesDataToDatabase]
	(
	@MaDauSach nvarchar(20),
	@MaTL nvarchar(20),
	@TenSach nvarchar(100)
	)
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
update DAUSACH set MaTL = @MaTL,TenSach = @TenSach where MaDauSach = @MaDauSach
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[UpdateBookQuantityToDatabase]    Script Date: 12/22/2013 10:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateBookQuantityToDatabase]
	@MaSach nvarchar(20),
	@SoLuong int
AS
	/* SET NOCOUNT ON */
	Update SACH set SoLuong = SoLuong where MaSach = @MaSach
	RETURN
GO
/****** Object:  Table [dbo].[TONKHO]    Script Date: 12/22/2013 10:32:00 ******/
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
/****** Object:  View [dbo].[THONGTINSACH]    Script Date: 12/22/2013 10:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[THONGTINSACH]
AS
SELECT        dbo.CHITIETTACGIA.MaDauSach, dbo.DAUSACH.TenSach, dbo.NHAXUATBAN.TenNXB, dbo.SACH.MaSach, dbo.SACH.MaNXB, dbo.SACH.NamXB, dbo.SACH.GiaNhap, 
                         dbo.SACH.SoLuong, dbo.TACGIA.TenTG, dbo.THELOAI.TenTL, dbo.NHAXUATBAN.MaNXB AS Expr1
FROM            dbo.CHITIETTACGIA INNER JOIN
                         dbo.DAUSACH ON dbo.CHITIETTACGIA.MaDauSach = dbo.DAUSACH.MaDauSach INNER JOIN
                         dbo.SACH ON dbo.DAUSACH.MaDauSach = dbo.SACH.MaDauSach INNER JOIN
                         dbo.NHAXUATBAN ON dbo.SACH.MaNXB = dbo.NHAXUATBAN.MaNXB INNER JOIN
                         dbo.TACGIA ON dbo.CHITIETTACGIA.MaTG = dbo.TACGIA.MaTG INNER JOIN
                         dbo.THELOAI ON dbo.DAUSACH.MaTL = dbo.THELOAI.MaTL
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "CHITIETTACGIA"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 101
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DAUSACH"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 114
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "NHAXUATBAN"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 118
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SACH"
            Begin Extent = 
               Top = 6
               Left = 662
               Bottom = 135
               Right = 832
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "TACGIA"
            Begin Extent = 
               Top = 6
               Left = 870
               Bottom = 118
               Right = 1040
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "THELOAI"
            Begin Extent = 
               Top = 102
               Left = 38
               Bottom = 197
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'THONGTINSACH'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'THONGTINSACH'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'THONGTINSACH'
GO
/****** Object:  View [dbo].[THONGTINDAUSACH]    Script Date: 12/22/2013 10:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[THONGTINDAUSACH]
AS
SELECT        dbo.DAUSACH.TenSach, dbo.CHITIETTACGIA.MaDauSach, dbo.TACGIA.TenTG, dbo.THELOAI.TenTL
FROM            dbo.CHITIETTACGIA INNER JOIN
                         dbo.DAUSACH ON dbo.CHITIETTACGIA.MaDauSach = dbo.DAUSACH.MaDauSach INNER JOIN
                         dbo.TACGIA ON dbo.CHITIETTACGIA.MaTG = dbo.TACGIA.MaTG INNER JOIN
                         dbo.THELOAI ON dbo.DAUSACH.MaTL = dbo.THELOAI.MaTL
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "CHITIETTACGIA"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 101
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DAUSACH"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 118
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TACGIA"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 118
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "THELOAI"
            Begin Extent = 
               Top = 6
               Left = 662
               Bottom = 101
               Right = 832
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'THONGTINDAUSACH'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'THONGTINDAUSACH'
GO
/****** Object:  Table [dbo].[CHITIETPHIEUNHAP]    Script Date: 12/22/2013 10:32:00 ******/
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
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 12/22/2013 10:32:00 ******/
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
/****** Object:  Trigger [AutoIncrementReceptsId]    Script Date: 12/22/2013 10:32:00 ******/
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
/****** Object:  StoredProcedure [dbo].[AddBookDataToDatabase]    Script Date: 12/22/2013 10:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddBookDataToDatabase]
	(
	@MaSach nvarchar(20),
	@MaDauSach nvarchar(20),
	@MaNXB nvarchar(20),
	@GiaNhap money,
	@SoLuong int,
	@NamXB int

	)
	AS
	insert into SACH values(@MaSach,@MaDauSach,@MaNXB,@NamXB,@GiaNhap,@SoLuong)

	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/

	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[AddAuthorDetailDataToDatabase]    Script Date: 12/22/2013 10:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddAuthorDetailDataToDatabase]
	(
	@MaTG nvarchar(20),
	@MaDauSach nvarchar(20)
	)
	AS
	insert into CHITIETTACGIA  values(@MaDauSach,@MaTG)

	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/

	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  Trigger [AutoIncrementBookImportId]    Script Date: 12/22/2013 10:32:00 ******/
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
/****** Object:  Trigger [AutoIncrementBookId]    Script Date: 12/22/2013 10:32:00 ******/
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
GO
/****** Object:  StoredProcedure [dbo].[AddReceiptNodeDataToDatabase]    Script Date: 12/22/2013 10:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddReceiptNodeDataToDatabase]
	@MaPhieuNhap nvarchar(20),
	@MaNV nvarchar(20),
	@NgayNhapSach smalldatetime,
	@TongSoLuong int,
	@TongTien money
AS
	Insert into PHIEUNHAPSACH values(@MaPhieuNhap, @MaNV, @NgayNhapSach, @TongSoLuong, @TongTien)
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[DeleteBookDataToDatabase]    Script Date: 12/22/2013 10:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteBookDataToDatabase]
(
@MaSach nvarchar(20)
)	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
delete from SACH where MaSach =@MaSach
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[DeleteAuthorDetailDataToDatabase]    Script Date: 12/22/2013 10:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteAuthorDetailDataToDatabase]
	@MaTG nvarchar(20),
 	@MaDauSach nvarchar(20)
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
delete from CHITIETTACGIA where MaTG = @MaTG and MaDauSach = @MaDauSach 
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[GetEmployeeDataFromDatabase]    Script Date: 12/22/2013 10:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetEmployeeDataFromDatabase]
as
select * from THONGTINNHANVIEN
GO
/****** Object:  StoredProcedure [dbo].[UpdateBookDataToDatabase]    Script Date: 12/22/2013 10:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateBookDataToDatabase]
	(
	@MaSach nvarchar(20),
	@MaDauSach nvarchar(20),
	@MaNXB nvarchar(20),
	@GiaNhap money,
	@SoLuong int,
	@NamXB int

	)
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
update SACH set MaDauSach = @MaDauSach,MaNXB = @MaNXB,GiaNhap = @GiaNhap,SoLuong = @SoLuong,NamXB = @NamXB where MaSach = @MaSach
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[UpdateReceiptNodeDataToDatabase]    Script Date: 12/22/2013 10:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateReceiptNodeDataToDatabase]
	@MaPhieuNhap nvarchar(20),
	@MaNV nvarchar(20),
	@NgayNhapSach smalldatetime,
	@TongSoLuong int,
	@TongTien money
AS
	Update PHIEUNHAPSACH set MaNV = @MaNV, NgayNhapSach = @NgayNhapSach,TongSoLuong =  @TongSoLuong,TongTien =  @TongTien where MaPhieuNhap = @MaPhieuNhap
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[DeleteReceiptNodeDataToDatabase]    Script Date: 12/22/2013 10:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteReceiptNodeDataToDatabase]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	@MaPhieuNhap nvarchar(20)
AS
  Delete from PHIEUNHAPSACH where MaPhieuNhap = @MaPhieuNhap
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[UpdateReceiptNodeDetailToDatabase]    Script Date: 12/22/2013 10:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateReceiptNodeDetailToDatabase]
	@MaPhieuNhap nvarchar(20),
	@MaSach nvarchar(20),
	@SoLuong int,
	@DonGia money,
	@ThanhTien money
AS
Update CHITIETPHIEUNHAP set MaSach = @MaSach,SoLuong = @SoLuong,DonGia = @DonGia,ThanhTien = @ThanhTien where MaPhieuNhap = @MaPhieuNhap
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[GetBookDataFromDatabase]    Script Date: 12/22/2013 10:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetBookDataFromDatabase]
AS
BEGIN
	select DISTINCT THONGTINSACH.MaSach,THONGTINSACH.MaDauSach,THONGTINSACH.TenSach,DS.NhomTG,THONGTINSACH.TenTL,THONGTINSACH.NamXB,THONGTINSACH.MaNXB,THONGTINSACH.TenNXB,THONGTINSACH.GiaNhap,THONGTINSACH.SoLuong from THONGTINSACH inner join
(select MaDauSach,
 STUFF((Select ('- ') + TenTG from THONGTINSACH S2 where  S1.MaDauSach = S2.MaDauSach for XML PATH('')),1,1, '')
  NhomTG from THONGTINSACH S1 Group by MaDauSach) as DS on THONGTINSACH.MaDauSach = DS.MaDauSach
	END
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[GetBookTitlesDataFromDatabase]    Script Date: 12/22/2013 10:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetBookTitlesDataFromDatabase]
AS
BEGIN
select DISTINCT THONGTINDAUSACH.MaDauSach,THONGTINDAUSACH.TenSach,DS.NhomTG,THONGTINDAUSACH.TenTL from THONGTINDAUSACH inner join
(select MaDauSach,
 STUFF((Select ('- ') + TenTG from THONGTINDAUSACH DS2 where  DS1.MaDauSach = DS2.MaDauSach for XML PATH('')),1,1, '')
  NhomTG from THONGTINDAUSACH DS1 Group by MaDauSach) as DS on THONGTINDAUSACH.MaDauSach = DS.MaDauSach
	/* SET NOCOUNT ON */
	END
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[DeleteReceiptNodeDetailToDatabase]    Script Date: 12/22/2013 10:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteReceiptNodeDetailToDatabase]
	@MaPhieuNhap nvarchar(20)

AS
	Delete from CHITIETPHIEUNHAP where MaPhieuNhap = @MaPhieuNhap
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[AddReceiptNodeDetailToDatabase]    Script Date: 12/22/2013 10:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddReceiptNodeDetailToDatabase]
	@MaPhieuNhap nvarchar(20),
	@MaSach nvarchar(20),
	@SoLuong int,
	@DonGia money,
	@ThanhTien money
AS
Insert into CHITIETPHIEUNHAP values(@MaPhieuNhap,@MaSach,@SoLuong,@DonGia,@ThanhTien)
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  ForeignKey [FK_DAUSACH_THELOAI]    Script Date: 12/22/2013 10:31:58 ******/
ALTER TABLE [dbo].[DAUSACH]  WITH CHECK ADD  CONSTRAINT [FK_DAUSACH_THELOAI] FOREIGN KEY([MaTL])
REFERENCES [dbo].[THELOAI] ([MaTL])
GO
ALTER TABLE [dbo].[DAUSACH] CHECK CONSTRAINT [FK_DAUSACH_THELOAI]
GO
/****** Object:  ForeignKey [FK_CONGNO_KHACHHANG]    Script Date: 12/22/2013 10:31:58 ******/
ALTER TABLE [dbo].[CONGNO]  WITH CHECK ADD  CONSTRAINT [FK_CONGNO_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[CONGNO] CHECK CONSTRAINT [FK_CONGNO_KHACHHANG]
GO
/****** Object:  ForeignKey [FK_NHANVIEN_CHUCVU]    Script Date: 12/22/2013 10:31:58 ******/
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_CHUCVU] FOREIGN KEY([MaCV])
REFERENCES [dbo].[CHUCVU] ([MaCV])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_CHUCVU]
GO
/****** Object:  ForeignKey [FK_CHITIETTACGIA_DAUSACH]    Script Date: 12/22/2013 10:31:58 ******/
ALTER TABLE [dbo].[CHITIETTACGIA]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETTACGIA_DAUSACH] FOREIGN KEY([MaDauSach])
REFERENCES [dbo].[DAUSACH] ([MaDauSach])
GO
ALTER TABLE [dbo].[CHITIETTACGIA] CHECK CONSTRAINT [FK_CHITIETTACGIA_DAUSACH]
GO
/****** Object:  ForeignKey [FK_CHITIETTACGIA_TACGIA1]    Script Date: 12/22/2013 10:31:58 ******/
ALTER TABLE [dbo].[CHITIETTACGIA]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETTACGIA_TACGIA1] FOREIGN KEY([MaTG])
REFERENCES [dbo].[TACGIA] ([MaTG])
GO
ALTER TABLE [dbo].[CHITIETTACGIA] CHECK CONSTRAINT [FK_CHITIETTACGIA_TACGIA1]
GO
/****** Object:  ForeignKey [FK_SACH_DAUSACH]    Script Date: 12/22/2013 10:31:58 ******/
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_DAUSACH] FOREIGN KEY([MaDauSach])
REFERENCES [dbo].[DAUSACH] ([MaDauSach])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_DAUSACH]
GO
/****** Object:  ForeignKey [FK_SACH_NHAXUATBAN]    Script Date: 12/22/2013 10:31:58 ******/
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_NHAXUATBAN] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NHAXUATBAN] ([MaNXB])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_NHAXUATBAN]
GO
/****** Object:  ForeignKey [FK_PHIEUTHUTIEN_KHACHHANG]    Script Date: 12/22/2013 10:31:58 ******/
ALTER TABLE [dbo].[PHIEUTHUTIEN]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHUTIEN_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[PHIEUTHUTIEN] CHECK CONSTRAINT [FK_PHIEUTHUTIEN_KHACHHANG]
GO
/****** Object:  ForeignKey [FK_PHIEUTHUTIEN_NHANVIEN]    Script Date: 12/22/2013 10:31:58 ******/
ALTER TABLE [dbo].[PHIEUTHUTIEN]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHUTIEN_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUTHUTIEN] CHECK CONSTRAINT [FK_PHIEUTHUTIEN_NHANVIEN]
GO
/****** Object:  ForeignKey [FK_PHIEUNHAPSACH_NHANVIEN]    Script Date: 12/22/2013 10:31:58 ******/
ALTER TABLE [dbo].[PHIEUNHAPSACH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAPSACH_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUNHAPSACH] CHECK CONSTRAINT [FK_PHIEUNHAPSACH_NHANVIEN]
GO
/****** Object:  ForeignKey [FK_HOADON_KHACHHANG]    Script Date: 12/22/2013 10:31:58 ******/
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG]
GO
/****** Object:  ForeignKey [FK_HOADON_NHANVIEN]    Script Date: 12/22/2013 10:31:58 ******/
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_NHANVIEN]
GO
/****** Object:  ForeignKey [FK_TONKHO_SACH]    Script Date: 12/22/2013 10:32:00 ******/
ALTER TABLE [dbo].[TONKHO]  WITH CHECK ADD  CONSTRAINT [FK_TONKHO_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[TONKHO] CHECK CONSTRAINT [FK_TONKHO_SACH]
GO
/****** Object:  ForeignKey [FK_CHITIETPHIEUNHAP_PHIEUNHAPSACH]    Script Date: 12/22/2013 10:32:00 ******/
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUNHAP_PHIEUNHAPSACH] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PHIEUNHAPSACH] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [FK_CHITIETPHIEUNHAP_PHIEUNHAPSACH]
GO
/****** Object:  ForeignKey [FK_CHITIETPHIEUNHAP_SACH]    Script Date: 12/22/2013 10:32:00 ******/
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUNHAP_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [FK_CHITIETPHIEUNHAP_SACH]
GO
/****** Object:  ForeignKey [FK_CHITIETHOADON_HOADON]    Script Date: 12/22/2013 10:32:00 ******/
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_HOADON] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_HOADON]
GO
/****** Object:  ForeignKey [FK_CHITIETHOADON_SACH]    Script Date: 12/22/2013 10:32:00 ******/
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_SACH]
GO
