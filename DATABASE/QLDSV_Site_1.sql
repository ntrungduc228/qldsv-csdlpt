

create proc [dbo].[getAllLopByRole] @type integer
as
begin
	if(@type = 0)
	begin
		select MALOP, TENLOP from LINK0.QLDSV_TC.dbo.LOP
	end
	else if(@type = 1)
	begin
		select MALOP, TENLOP from dbo.LOP
	end
end

