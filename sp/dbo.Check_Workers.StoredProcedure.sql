USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[Check_Workers]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Check_Workers](@id varchar(9),@myOut int out) as
begin
if EXISTS (select [Id] from [dbo].[Workers] where [dbo].[Workers].[Id]=@id)
set @myOut=0
else
set @myOut=1
end


GO
