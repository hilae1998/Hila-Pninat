USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[Check_Customers]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Check_Customers](@id varchar(9),@myOut int out) as
begin
if EXISTS(select [id] from [dbo].[Customers] where [dbo].[Customers].[id]=@id)
begin
set @myOut=0
end
else
begin
set @myOut=1
end
end


GO
