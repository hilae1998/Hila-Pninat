USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[getPatiantsById]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[getPatiantsById] 
@id varchar(9)
as
begin
	select * 
	from [dbo].[Patiants]
	where @id = [dbo].[Patiants].[Id]
end



GO
