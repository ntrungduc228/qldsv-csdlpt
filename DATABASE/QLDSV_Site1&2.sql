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

/****** Object:  StoredProcedure [dbo].[SP_FULLMARK]    Script Date: 29/05/2022 12:48:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_FULLMARK] @MSSV varchar(10) , @Type int
--0:PGV
--1:Khoa (Chỉ thực hiện trên đúng 1 sv hiện tại)
as
IF (@Type = 0)
BEGIN
	IF EXISTS (SELECT 1 FROM SINHVIEN WHERE MASV=@MSSV)  
				BEGIN
                    select MONHOC.TENMH, DIEMTK = max(DSDK.DIEMTK)
					from (select LOPTINCHI.MAMH,DIEMTK= DIEM_CC * 0.1 + DIEM_GK * 0.3 + DIEM_CK * 0.6 
										from DANGKY,LOPTINCHI 
										where DANGKY.MASV = @MSSV AND DANGKY.MALTC = LOPTINCHI.MALTC AND HUYDANGKY=0) as DSDK, MONHOC
					where MONHOC.MAMH = DSDK.MAMH
					group by TENMH
                END
	ELSE IF  EXISTS (SELECT 1 FROM LINK1.QLDSV_TC.dbo.SINHVIEN WHERE MASV=@MSSV) 
				BEGIN
                    select MONHOC.TENMH, DIEMTK = max(DSDK.DIEMTK)
					from (select LOPTINCHI.MAMH,DIEMTK= DIEM_CC * 0.1 + DIEM_GK * 0.3 + DIEM_CK * 0.6 
										from DANGKY,LOPTINCHI 
										where DANGKY.MASV = @MSSV AND DANGKY.MALTC = LOPTINCHI.MALTC AND HUYDANGKY=0) as DSDK, MONHOC
					where MONHOC.MAMH = DSDK.MAMH
					group by TENMH
                END
	ELSE IF  EXISTS (SELECT 1 FROM LINK0.QLDSV_TC.dbo.SINHVIEN WHERE MASV=@MSSV) 
				BEGIN
                    select MONHOC.TENMH, DIEMTK = max(DSDK.DIEMTK)
					from (select LOPTINCHI.MAMH,DIEMTK= DIEM_CC * 0.1 + DIEM_GK * 0.3 + DIEM_CK * 0.6 
										from DANGKY,LOPTINCHI 
										where DANGKY.MASV = @MSSV AND DANGKY.MALTC = LOPTINCHI.MALTC AND HUYDANGKY=0) as DSDK, MONHOC
					where MONHOC.MAMH = DSDK.MAMH
					group by TENMH
                END
ELSE
	RAISERROR(N'SINH VIÊN NÀY KHÔNG TỒN TẠI',16,1)
END
ELSE --neu la khoa
BEGIN
	IF EXISTS (SELECT 1 FROM SINHVIEN WHERE MASV=@MSSV)  
				BEGIN
                    select MONHOC.TENMH, DIEMTK = max(DSDK.DIEMTK)
					from (select LOPTINCHI.MAMH,DIEMTK= DIEM_CC * 0.1 + DIEM_GK * 0.3 + DIEM_CK * 0.6 
										from DANGKY,LOPTINCHI 
										where DANGKY.MASV = @MSSV AND DANGKY.MALTC = LOPTINCHI.MALTC AND HUYDANGKY=0) as DSDK, MONHOC
					where MONHOC.MAMH = DSDK.MAMH
					group by TENMH
                END
	ELSE
		RAISERROR(N'SINH VIÊN NÀY KHÔNG TỒN TẠI',16,1)
END


 ALTER PROC [dbo].[SP_TAOLOGIN]
  @LGNAME VARCHAR(50),
  @PASS VARCHAR(50),
  @USERNAME VARCHAR(50),
  @ROLE VARCHAR(50)
AS

	-- check login , user bị trùng 
	IF EXISTS(SELECT name FROM sys.server_principals 
				WHERE name = @LGNAME)				--G: Windows Group Login Accounts
		RETURN 1	--Trùng Login
	ELSE IF EXISTS(SELECT name FROM sys.database_principals
					WHERE type_desc = 'SQL_USER'
					AND name = @USERNAME)
		RETURN 2	--Trùng User

	-- băt đầu tạo tài khoản
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'QLDSV_TC'
  IF (@RET =1) 
     RETURN 3 -- tạo tài khoản không thành công
 
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1) 
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 3 -- tạo  tài khoảng không thành công
  END
  EXEC sp_addrolemember @ROLE, @USERNAME

  --THEM ROLE SECURITYADMIN DE CO QUYEN TAO TAI KHOAN
  EXEC sp_addsrvrolemember @LGNAME, 'securityadmin'

  RETURN 0  -- THANH CONG

    create proc [dbo].[GetAllNienKhoa] as 
select NIENKHOA from LOPTINCHI group by NIENKHOA

CREATE proc [dbo].[GetAllHocKy] @NIENKHOA nchar(9)  as 
select HOCKY from LOPTINCHI where NIENKHOA= @NIENKHOA group by HOCKY

  CREATE PROC [dbo].[SP_getInfoSVDKI]
@masv NCHAR(10)
AS
BEGIN
	SELECT MASV,HO,TEN,MALOP FROM dbo.SINHVIEN WHERE MASV = @masv
END

CREATE proc [dbo].[SP_LIST_SVHUYDANGKY] @MASSV varchar(20)
as
with GETLIST_HUYDANGKY(MALTC,NIENKHOA,HOCKY,MAMH,MAGV,NHOM)
as
(select DANGKY.MALTC,NIENKHOA,HOCKY,MAMH,MAGV,NHOM 
from DANGKY,LOPTINCHI
where DANGKY.MASV=@MASSV AND DANGKY.MALTC = LOPTINCHI.MALTC AND DANGKY.HUYDANGKY = 0 
AND DANGKY.DIEM_CC IS NULL AND DANGKY.DIEM_CK IS NULL AND DANGKY.DIEM_GK IS NULL	
)
select A.MALTC,NIENKHOA,HOCKY,TENMH,HOTENGV=HO + ' '+ TEN,NHOM
from (select MALTC,NIENKHOA,HOCKY,HO,TEN,NHOM
from GETLIST_HUYDANGKY,GIANGVIEN
where GETLIST_HUYDANGKY.MAGV = GIANGVIEN.MAGV) as A,
(select MALTC,TENMH from GETLIST_HUYDANGKY,MONHOC 
where GETLIST_HUYDANGKY.MAMH = MONHOC.MAMH) as B
where A.MALTC = B.MALTC

CREATE PROC [dbo].[SP_getInfoSVDKI]
@masv NCHAR(10)
AS
BEGIN
	SELECT MASV,HO,TEN,MALOP FROM dbo.SINHVIEN WHERE MASV = @masv
END


CREATE PROCEDURE [dbo].[SP_XULY_LTC] @MASV NVARCHAR(10),  
@MALTC INT,  
@type smallint
--type=1 : đăng ký
--type=0 : hủy
-- SP này để vừa cho sinh viên đăng ký hoặc hủy môn đăng ký
AS  
BEGIN  
	IF (@type=1)
	BEGIN
            IF EXISTS (SELECT 1 FROM DANGKY WHERE MASV=@MASV AND MALTC=@MALTC)  
				BEGIN
                    raiserror(N'SINH VIÊN ĐÃ ĐĂNG KÝ LỚP',16,1)
					RETURN
                END  
            ELSE  
                BEGIN  
                    INSERT INTO DBO.DANGKY(MALTC, MASV,HUYDANGKY)  
                    VALUES (@MALTC, @MASV,0)  
                END
	END
	ELSE IF(@type = 2)
	BEGIN
		IF EXISTS (SELECT 1 FROM DANGKY WHERE MASV=@MASV AND MALTC=@MALTC)  
				BEGIN
                    UPDATE DANGKY SET HUYDANGKY=1 WHERE MALTC = @MALTC AND MASV = @MASV
                END
		ELSE
			BEGIN
				raiserror(N'SINH VIÊN CHƯA ĐĂNG KÝ LỚP',16,1)
				
			END
	END
		
END

CREATE PROCEDURE [dbo].[SP_InDanhSachLopTinChi] @NienKhoa varchar(9), @HocKy int
AS
with SOSVDK (MALTC,MAMH,MAGV,NHOM,SOSVTOITHIEU,AMOUNT) as
(select LOPTINCHI.MALTC,MAMH,MAGV,NHOM,SOSVTOITHIEU,count(DANGKY.MALTC) from LOPTINCHI 
left join DANGKY
on DANGKY.MALTC = LOPTINCHI.MALTC 
where HUYLOP=0 AND LOPTINCHI.NIENKHOA = @NienKhoa AND LOPTINCHI.HOCKY = @HocKy 
group by LOPTINCHI.MALTC,MAMH,MAGV,NHOM,SOSVTOITHIEU)
select A.MALTC,TENMH,NHOM,HOTEN,SOSVTOITHIEU,AMOUNT
from (select MALTC,TENMH from SOSVDK,MONHOC where SOSVDK.MAMH = MONHOC.MAMH) as A,
(select MALTC,NHOM,HOTEN=HO+' '+TEN,SOSVDK.SOSVTOITHIEU,AMOUNT from SOSVDK,GIANGVIEN where SOSVDK.MAGV=GIANGVIEN.MAGV) as B
where A.MALTC=B.MALTC