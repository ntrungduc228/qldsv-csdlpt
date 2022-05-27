USE [QLDSV_TC]
GO
/****** Object:  StoredProcedure [dbo].[SP_LayDSGV]    Script Date: 17/05/2022 12:57:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_LayDSGV] AS
BEGIN
	SELECT MAGV,HOTEN = HO+' '+TEN FROM dbo.GIANGVIEN 
END
go

/****** Object:  StoredProcedure [dbo].[SP_CHECKID]    Script Date: 17/05/2022 12:58:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SP_CHECKID] @Code NVARCHAR(15),
@Type NVARCHAR(15)
AS
BEGIN
	-- LOP
	IF(@Type = 'MALOP')
	BEGIN
		
		IF EXISTS(SELECT * FROM dbo.LOP WHERE dbo.LOP.MALOP = @Code)
			RETURN 1; -- Mã tồn tại ở phân mãnh hiện tại
	
		ELSE IF EXISTS(SELECT * FROM LINK0.QLDSV_TC.dbo.LOP AS LOP WHERE LOP.MALOP = @Code)
			RETURN 2;	--Mã NV tồn tại ở phân mãnh  khác
	END

	--MON Hoc
	IF(@Type = 'MAMONHOC')
	BEGIN
		IF EXISTS(SELECT * FROM dbo.MONHOC WHERE MAMH = @Code)
		RETURN 1;
	END
	
	


		IF(@Type = 'MASV')
	BEGIN
		
		IF EXISTS(SELECT * FROM dbo.SINHVIEN WHERE dbo.SINHVIEN.MASV = @Code)
			RETURN 1; -- Mã tồn tại ở phân mãnh hiện tại
	
		ELSE IF EXISTS(SELECT * FROM LINK0.QLDSV_TC.dbo.SINHVIEN AS SV WHERE SV.MASV = @Code)
			RETURN 2;	--Mã NV tồn tại ở phân mãnh  khác
	END

	RETURN 0	--Không bị trùng được thêm
END


/****** Object:  StoredProcedure [dbo].[SP_CHECKNAME]    Script Date: 17/05/2022 1:00:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[SP_CHECKNAME]
@Name NVARCHAR(50),
@Type NVARCHAR(15)
AS
BEGIN
	--Kiểm tra Table lop của server hiện tại
	IF(@Type = 'TENLOP')
	BEGIN
		IF EXISTS(SELECT * FROM dbo.LOP WHERE dbo.LOP.TENLOP = @Name)
			RETURN 1; -- @name bị trùng  ở phân mãnh hiện tại
	
		ELSE IF EXISTS(SELECT * FROM LINK0.QLDSV_TC.dbo.LOP AS LOP WHERE LOP.TENLOP = @Name)
			RETURN 2;	--@name bị trùng ở phân mãnh  khác
	END

	IF(@Type = 'TENMONHOC')
	BEGIN
		IF EXISTS(SELECT * FROM dbo.MONHOC WHERE TENMH = @Name)
		RETURN 1;
	END
	
	RETURN 0	--Không bị trùng ,được thêm
END

/****** Object:  StoredProcedure [dbo].[GetAllHocKy]    Script Date: 18/05/2022 11:52:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllHocKy] @NIENKHOA nchar(9)  as 
select HOCKY from LOPTINCHI where NIENKHOA= @NIENKHOA group by HOCKY


/****** Object:  StoredProcedure [dbo].[GetAllNienKhoa]    Script Date: 18/05/2022 11:52:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllNienKhoa] as 
select NIENKHOA from LOPTINCHI group by NIENKHOA

/****** Object:  StoredProcedure [dbo].[GetAllNhom]    Script Date: 18/05/2022 11:53:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllNhom] @NIENKHOA varchar(9), @HOCKI int
as select NHOM FROM LOPTINCHI where @NIENKHOA = NIENKHOA AND HOCKY = @HOCKI group by NHOM

/****** Object:  StoredProcedure [dbo].[SP_LAY_DSSV_DANGKY]    Script Date: 18/05/2022 11:53:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_LAY_DSSV_DANGKY] 
@NienKhoa varchar(9), @HocKy int, @Nhom int,@MonHoc nvarchar(50) as
begin
	declare @LOPTINCHI int
	select @LOPTINCHI = ltc.MALTC
	from MONHOC, (select maltc,MAMH from LOPTINCHI where NIENKHOA = @NienKhoa and HOCKY = @HocKy and NHOM = @Nhom) as LTC
	where MONHOC.MAMH = LTC.MAMH and MONHOC.TENMH = @MonHoc

	select MALTC = @LOPTINCHI, sv.MASV, HOTEN= HO+' '+TEN, DIEM_CC, DIEM_GK, DIEM_CK
	from (select MASV, DIEM_CC, DIEM_CK, DIEM_GK from DANGKY where MALTC = @LOPTINCHI and HUYDANGKY = 'FALSE') DSDK,SINHVIEN SV
	where DSDK.MASV = sv.MASV
end

/****** Object:  StoredProcedure [dbo].[SP_UPDATE_DIEM]    Script Date: 18/05/2022 11:53:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_UPDATE_DIEM] 
@DIEMTHI TYPE_DANGKY readonly
as
begin
	merge into DANGKY as target
	using (select MALTC, MASV, DIEM_CC, DIEM_GK, DIEM_CK from @DIEMTHI) AS Source
	on target.MALTC= source.MALTC AND Target.MASV= source.MASV
	when matched then
		update set target.DIEM_CC = source.DIEM_CC, target.DIEM_GK = source.DIEM_GK, target.DIEM_CK = source.DIEM_CK
	when not matched then
		insert (MALTC, MASV, DIEM_CC,DIEM_GK, DIEM_CK)
			values (source.MALTC, source.MASV, source.DIEM_CC, source.DIEM_GK, source.DIEM_CK);
end