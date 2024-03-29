USE [MANAGERBOOKSTORE]
GO
/****** Object:  StoredProcedure [dbo].[UpdateReceiptNoteDetailToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateReceiptNoteDetailToDatabase]
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
/****** Object:  StoredProcedure [dbo].[DeleteReceiptNoteDetailDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteReceiptNoteDetailDataToDatabase]
	@MaPhieuNhap nvarchar(20)

AS
	Delete from CHITIETPHIEUNHAP where MaPhieuNhap = @MaPhieuNhap
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[AddReceiptNoteDetailDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddReceiptNoteDetailDataToDatabase]
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
/****** Object:  StoredProcedure [dbo].[UpdateDeliveryNoteDetailToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateDeliveryNoteDetailToDatabase]
	@MaHD nvarchar(20),
	@MaSach nvarchar(20),
	@SoLuong int,
	@DonGia money,
	@ThanhTien money
AS
Update CHITIETHOADON set MaSach = @MaSach,SoLuong = @SoLuong,DonGia = @DonGia,ThanhTien = @ThanhTien where MaHD = @MaHD
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[DeleteDeliveryNoteDetailDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteDeliveryNoteDetailDataToDatabase]
	@MaHD nvarchar(20),
	@MaSach nvarchar(20)
AS
	Delete from CHITIETHOADON where MaHD = @MaHD and MaSach = @MaSach
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[AddDeliveryNoteDetailDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddDeliveryNoteDetailDataToDatabase]
	@MaHD nvarchar(20),
	@MaSach nvarchar(20),
	@SoLuong int,
	@DonGia money,
	@ThanhTien money
AS
Insert into CHITIETHOADON values(@MaHD,@MaSach,@SoLuong,@DonGia,@ThanhTien)
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[UpdateBookQuantityToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[UpdateBookDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[getBookQuantityDataFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getBookQuantityDataFromDatabase]
@MaSach nvarchar(20)
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
select SoLuong from SACH where MaSach = @MaSach
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[DeleteBookDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[AddBookDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[GetReceiptNoteDetailDataFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetReceiptNoteDetailDataFromDatabase]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	select DISTINCT THONGTINCT_PHIEUNHAP.MaSach,THONGTINCT_PHIEUNHAP.TenSach,DS.NhomTG,THONGTINCT_PHIEUNHAP.TenTL,THONGTINCT_PHIEUNHAP.TenNXB,THONGTINCT_PHIEUNHAP.DonGia,THONGTINCT_PHIEUNHAP.SoLuong,THONGTINCT_PHIEUNHAP.ThanhTien from THONGTINCT_PHIEUNHAP inner join
(select MaDauSach,
 STUFF((Select ('- ') + TenTG from THONGTINCT_PHIEUNHAP S2 where  S1.MaDauSach = S2.MaDauSach for XML PATH('')),1,1, '')
  NhomTG from THONGTINCT_PHIEUNHAP S1 Group by MaDauSach) as DS on THONGTINCT_PHIEUNHAP.MaDauSach = DS.MaDauSach
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[GetDeliveryNoteDetailDataFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetDeliveryNoteDetailDataFromDatabase]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	select DISTINCT THONGTINCT_HOADON.MaSach,THONGTINCT_HOADON.TenSach,DS.NhomTG,THONGTINCT_HOADON.TenTL,THONGTINCT_HOADON.TenNXB,THONGTINCT_HOADON.DonGia,THONGTINCT_HOADON.SoLuong,THONGTINCT_HOADON.ThanhTien from THONGTINCT_HOADON inner join
(select MaDauSach,
 STUFF((Select ('- ') + TenTG from THONGTINCT_HOADON S2 where  S1.MaDauSach = S2.MaDauSach for XML PATH('')),1,1, '')
  NhomTG from THONGTINCT_HOADON S1 Group by MaDauSach) as DS on THONGTINCT_HOADON.MaDauSach = DS.MaDauSach
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[GetDeliveryNoteDetailDataByRuleFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetDeliveryNoteDetailDataByRuleFromDatabase]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	@MaHD nvarchar(20)
AS
	select DISTINCT MaHD,THONGTINCT_HOADON.MaSach,THONGTINCT_HOADON.TenSach,DS.NhomTG,THONGTINCT_HOADON.TenTL,THONGTINCT_HOADON.TenNXB,THONGTINCT_HOADON.DonGia,THONGTINCT_HOADON.SoLuong,THONGTINCT_HOADON.ThanhTien from THONGTINCT_HOADON inner join
(select MaDauSach,
 STUFF((Select ('- ') + TenTG from THONGTINCT_HOADON S2 where  S1.MaDauSach = S2.MaDauSach for XML PATH('')),1,1, '')
  NhomTG from THONGTINCT_HOADON S1 Group by MaDauSach) as DS on THONGTINCT_HOADON.MaDauSach = DS.MaDauSach
  where MaHD = @MaHD
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[AddRegulationsDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddRegulationsDataToDatabase]
	(
	@SoLuongNhapToiThieu int,
	@SoTienNoToiDa int,
	@SoLuongTonToiThieuSauBan int,
	@SoLuongTonToiDaTruocNhap int,
	@SuDungQuyDinh4 int,
	@DoTuoiNhanVienToiThieu int,
	@DoTuoiNhanVienToiDa int
	)
	AS
	insert into QUYDINH values(@SoLuongNhapToiThieu,@SoTienNoToiDa,@SoLuongTonToiThieuSauBan,
	@SoLuongTonToiDaTruocNhap,@SuDungQuyDinh4,@DoTuoiNhanVienToiThieu,@DoTuoiNhanVienToiDa)

	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/

	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[AddBookGenreDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[AddAuthorDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[AddCustomerDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[AddChargeDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddChargeDataToDatabase]
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
/****** Object:  StoredProcedure [dbo].[DeleteAuthorDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[DeletePublisherDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[DeleteCustomerDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[DeleteChargeDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[DeleteBookGenreDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[AddPublisherDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[GetBookGenreDataFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[GetAuthorDataFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[GetCustomerDebitsDataFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCustomerDebitsDataFromDatabase]
@MaKH nvarchar(20)
as
select TienNo from KHACHHANG where MaKH = @MaKH
GO
/****** Object:  StoredProcedure [dbo].[GetCustomerDataFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCustomerDataFromDatabase]
as
select * from KHACHHANG
GO
/****** Object:  StoredProcedure [dbo].[GetCustomerDataByRuleFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCustomerDataByRuleFromDatabase]
	@TenKH nvarchar(255),
	@GioiTinh nvarchar(5),
	@DiaChi nvarchar(255),
	@Email nvarchar(255),
	@SoDienThoai nvarchar(255),
	@TienNo money
as
select * from KHACHHANG
where TenKH like '%'+@TenKH+'%' and GioiTinh like '%'+@GioiTinh+'%' and  Email like '%'+@Email+'%' and SoDienThoai like '%'+@SoDienThoai+'%' and DiaChi like '%'+@DiaChi+'%'
 and TienNo >= @TienNo
GO
/****** Object:  StoredProcedure [dbo].[GetChargeDataFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[GetPublisherDataFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[LookAtPublisherDataFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[UpdateRegulationsDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateRegulationsDataToDatabase]
	(
	@SoLuongNhapToiThieu int,
	@SoTienNoToiDa int,
	@SoLuongTonToiThieuSauBan int,
	@SoLuongTonToiDaTruocNhap int,
	@SuDungQuyDinh4 int,
	@DoTuoiNhanVienToiThieu int,
	@DoTuoiNhanVienToiDa int
	)
	AS
	Update QUYDINH set  SoLuongNhapToiThieu = @SoLuongNhapToiThieu, SoTienNoToiDa = @SoTienNoToiDa,SoLuongTonToiThieuSauBan = @SoLuongTonToiThieuSauBan,
	SoLuongTonToiDaTruocNhap = @SoLuongTonToiDaTruocNhap,SuDungQuyDinh4 = @SuDungQuyDinh4,DoTuoiNhanVienToiThieu = @DoTuoiNhanVienToiThieu,DoTuoiNhanVienToiDa = @DoTuoiNhanVienToiDa

	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/

	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[UpdatePublisherDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[UpdateBookGenreDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[UpdateAuthorDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[UpdateDebitOfCustomerDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateDebitOfCustomerDataToDatabase]
	(
	@MaKH  nvarchar(20),
	@SoTienNo money
	)
	AS
	Update KHACHHANG set TienNo = @SoTienNo
	where MaKH = @MaKH

	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/

	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomerDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[UpdateChargeDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[LookAtCustomerDataFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[LookAtChargeDataFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[LookAtBookGenreDataFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[LookAtAuthorDataFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[GetRegulationsDataFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetRegulationsDataFromDatabase]

	AS
	select* from QUYDINH
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/

	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[GetRegulationsDataByNameFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetRegulationsDataByNameFromDatabase]
    @TenQuyDinh nvarchar(255)
	AS
	select @TenQuyDinh as Value from QUYDINH
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/

	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[GetBookTitlesMaxIdFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetBookTitlesMaxIdFromDatabase]
AS
	Select Max(MaDauSach) from DAUSACH
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[UpdateBookTitlesDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[UpdateLiabilitiesDataToDataBase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROC [dbo].[UpdateLiabilitiesDataToDataBase]
@MaKH nvarchar(20),
@NgayThu smalldatetime,
@TienNo money
AS
BEGIN
	DECLARE @MaCongNo VARCHAR(15),@TienNoDau money,@TienNoCuoi money,@TienNoPhatSinh money,@TienNoCu money;
	--Lấy thông tin sách từ phiếu nhập
	Select @TienNoCu = TienNo from KHACHHANG where MaKH = @MaKH
	if @TienNo > @TienNoCu
		BEGIN
			--
			Set @TienNoPhatSinh = @TienNo - @TienNoCu
			Set @TienNoCuoi = @TienNo
		END
	else
		BEGIN
			--
			Set @TienNoCuoi = @TienNo
			Set @TienNoPhatSinh = 0
		END
	--
	Select @MaCongNo = MaCongNo from CONGNO where YEAR(ThangNam) = YEAR(@NgayThu) and MONTH(ThangNam) = MONTH(@NgayThu) and MaKH = @MaKH
	if @MaCongNo is NOT NULL
		BEGIN
			--Select @TienNoCuoi = NoCuoi from CONGNO where MaCongNo = @MaCongNo
			--Set @TienNoCuoi = @TienNoCuoi - @SoLuongBan
			Update CONGNO set NoCuoi = @TienNoCuoi, PhatSinh = (PhatSinh + @TienNoPhatSinh) where MaCongNo = @MaCongNo
		END
	else
		BEGIN
			--Select @SoLuongTonDau = TonCuoi from TONKHO
			-- where (YEAR(ThangNam) = YEAR(@NgayNhap) and MONTH(ThangNam) = MONTH(@NgayNhap)- 1) or (YEAR(ThangNam) = YEAR(@NgayNhap) and MONTH(ThangNam) = MONTH(@NgayNhap)- 1)  and MaTonKho = @MaTonKho
			Set @TienNoDau = (select Top 1 NoDau from CONGNO where MaKH = @MaKH order by MaCongNo desc)
			if @TienNoDau is NOT NULL
				BEGIN
					INSERT INTO CONGNO VALUES('CN0000000',@MaKH,@TienNoDau,@TienNoPhatSinh,@TienNoCuoi,@NgayThu)
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
/****** Object:  StoredProcedure [dbo].[UpdateEmployeeDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
	@MaCV nvarchar(20)
	)
	AS
	Update NHANVIEN set TenNV = @TenNV,GioiTinh = @GioiTinh,NgaySinh = @NgaySinh,Email = @Email
	,DienThoai = @SoDienThoai,DiaChi = @DiaChi,NgayVaoLam = @NgayVaoLam,MaCV = @MaCV
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
/****** Object:  StoredProcedure [dbo].[LookAtEmployeeDataFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[GetEmployeeUserNamePassWord]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[GetEmployeeUserNamePassWord]
(
	@UserName nvarchar(255),
	@PassWord nvarchar(255)
)
AS
	select * from NHANVIEN where NHANVIEN.UserName = @UserName and NHANVIEN.Password = @PassWord
RETURN
GO
/****** Object:  StoredProcedure [dbo].[GetEmployeeUserName]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[GetEmployeeUserName]
(
	@UserName nvarchar(255)
)
AS
	select MaNV from NHANVIEN where NHANVIEN.UserName = @UserName 
RETURN
GO
/****** Object:  StoredProcedure [dbo].[AddEmployeeDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[AddBookTitlesDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[DeleteBookTitlesDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[DeleteEmployeeDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[AddDeliveryNoteDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddDeliveryNoteDataToDatabase]
	@MaHD nvarchar(20),
	@MaKH nvarchar(20),
	@MaNV nvarchar(20),
	@NgayHD smalldatetime,
	@TongSoLuong int,
	@TongTien money
AS
	Insert into HOADON values(@MaHD,@MaKH, @MaNV, @NgayHD, @TongSoLuong, @TongTien)
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[AddCashReceiptVoucherDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddCashReceiptVoucherDataToDatabase]
	@MaPhieuThu nvarchar(20),
	@MaKH nvarchar(20),
	@MaNV nvarchar(20),
	@NgayThu smalldatetime,
	@SoTienThu money
AS
	Insert into PHIEUTHUTIEN values(@MaPhieuThu, @MaKH, @MaNV, @SoTienThu, @NgayThu)
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[AddAuthorDetailDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[DeleteReceiptNoteDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteReceiptNoteDataToDatabase]
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
/****** Object:  StoredProcedure [dbo].[DeleteDeliveryNoteDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteDeliveryNoteDataToDatabase]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	@MaHD nvarchar(20)
AS
  Delete from HOADON where MaHD = @MaHD
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[DeleteAuthorDetailDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[AddReceiptNoteDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddReceiptNoteDataToDatabase]
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
/****** Object:  StoredProcedure [dbo].[GetCashReceiptVoucherMaxIdFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCashReceiptVoucherMaxIdFromDatabase]
as

select Max(MaPhieuThu) from PHIEUTHUTIEN
GO
/****** Object:  StoredProcedure [dbo].[GetEmployeeDataFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetEmployeeDataFromDatabase]
as
select * from THONGTINNHANVIEN
GO
/****** Object:  StoredProcedure [dbo].[GetEmployeeDataByRuleFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetEmployeeDataByRuleFromDatabase]
	@TenNV nvarchar(255),
	@GioiTinh nvarchar(5),
	@DiaChi nvarchar(255),
	@Email nvarchar(255),
	@SoDienThoai nvarchar(255),
	@TenCV nvarchar(255)
as
select * from THONGTINNHANVIEN
where TenNV like '%'+@TenNV+'%' and GioiTinh like '%'+@GioiTinh+'%' and  Email like '%'+@Email+'%' and DienThoai like '%'+@SoDienThoai+'%' and DiaChi like '%'+@DiaChi+'%' and TenCV like '%'+@TenCV+'%'
GO
/****** Object:  StoredProcedure [dbo].[GetDeliveryNoteMaxIdFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetDeliveryNoteMaxIdFromDatabase]
as

select Max(MaHD) from HOADON
GO
/****** Object:  StoredProcedure [dbo].[UpdateReceiptNoteDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateReceiptNoteDataToDatabase]
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
/****** Object:  StoredProcedure [dbo].[UpdateDeliveryNoteDataToDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateDeliveryNoteDataToDatabase]
	@MaHD nvarchar(20),
	@MaNV nvarchar(20),
	@MaKH nvarchar(20),
	@NgayHD smalldatetime,
	@TongSoLuong int,
	@TongTien money
AS
	Update HOADON set MaNV = @MaNV,MaKH = @MaKH, NgayHD = @NgayHD,TongSoLuong =  @TongSoLuong,TongTien =  @TongTien where MaHD = @MaHD
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[GetBookDataFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetBookDataFromDatabase]
AS
BEGIN
	select DISTINCT THONGTINSACH.MaSach,THONGTINSACH.MaDauSach,THONGTINSACH.TenSach,DS.NhomTG,THONGTINSACH.TenTL,THONGTINSACH.NamXB,THONGTINSACH.MaNXB,THONGTINSACH.TenNXB,THONGTINSACH.GiaNhap,THONGTINSACH.SoLuong from THONGTINSACH inner join
(select MaDauSach,
 STUFF((Select ('- ') + TenTG from THONGTINDAUSACH DS2 where  DS1.MaDauSach = DS2.MaDauSach for XML PATH('')),1,1, '')
  NhomTG from THONGTINDAUSACH DS1 Group by MaDauSach) as DS on THONGTINSACH.MaDauSach = DS.MaDauSach
	END
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[GetBookDataByRuleFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetBookDataByRuleFromDatabase]
@TenSach nvarchar(255),
@NhomTG nvarchar(255),
@TenTL nvarchar(255),
@NamXB int,
@TenNXB nvarchar(255),
@SoLuong int,
@GiaNhap money
AS
BEGIN
	select DISTINCT THONGTINSACH.MaSach,THONGTINSACH.MaDauSach,THONGTINSACH.TenSach,DS.NhomTG,THONGTINSACH.TenTL,THONGTINSACH.NamXB,THONGTINSACH.MaNXB,THONGTINSACH.TenNXB,THONGTINSACH.GiaNhap,THONGTINSACH.SoLuong from THONGTINSACH inner join
(select MaDauSach,
 STUFF((Select ('- ') + TenTG from THONGTINDAUSACH DS2 where  DS1.MaDauSach = DS2.MaDauSach for XML PATH('')),1,1, '')
  NhomTG from THONGTINDAUSACH DS1 Group by MaDauSach) as DS on THONGTINSACH.MaDauSach = DS.MaDauSach
  Where TenSach like '%'+@TenSach+'%' and NhomTG like '%'+@NhomTG+'%' and TenTL like '%'+@TenTL+'%' and TenNXB like '%'+@TenNXB+'%' and SoLuong >= @SoLuong and NamXB >= @NamXB and GiaNhap >= @GiaNhap
	END
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[GetReceiptNoteMaxIdFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetReceiptNoteMaxIdFromDatabase]
as

select Max(MaPhieuNhap) from PHIEUNHAPSACH
GO
/****** Object:  StoredProcedure [dbo].[GetBookTitlesDataFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
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
/****** Object:  StoredProcedure [dbo].[GetDeliveryNoteDateFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetDeliveryNoteDateFromDatabase]
as
select * from THONGTINHOADON
GO
/****** Object:  StoredProcedure [dbo].[GetDeliveryDataByRuleFromDatabase]    Script Date: 01/04/2014 02:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetDeliveryDataByRuleFromDatabase]
	@SoHD  nvarchar(20),
	@TenNV nvarchar(255),
	@TenKH nvarchar(255),
	@NgayHD smalldatetime
as
select * from THONGTINHOADON
where TenNV like '%'+@TenNV+'%' and MaHD like '%'+@SoHD+'%' and  TenKH like '%'+@TenKH+'%' and Datediff(day,@NgayHD,NgayHD) >= 0
GO
