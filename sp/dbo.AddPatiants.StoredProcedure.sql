USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[AddPatiants]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AddPatiants] as
begin
	select [Id],[FirstName],[LastName]
	from [dbo].[Patiants]
end


GO
