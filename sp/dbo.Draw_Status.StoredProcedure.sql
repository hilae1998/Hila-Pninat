USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[Draw_Status]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Avishag
create procedure [dbo].[Draw_Status] as
begin
	select [Status]
	from [dbo].[Statuses]

end


GO
