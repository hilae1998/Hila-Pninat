USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[getCustomersById]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getCustomersById]
@id varchar(9)
as
begin
	select * 
	from [dbo].[Customers]
	where @id = [dbo].[Customers].[id]
end



GO
