USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[getVisitReason]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getVisitReason](@date DateTime,@id varchar(9)) as
begin
	select *
	from [dbo].[VisitReason] join [dbo].[Updatings]
	on [dbo].[VisitReason].[UpdateCode]=[dbo].[Updatings].[Code]
	join [dbo].[Patiants]
	on [dbo].[Updatings].[PatiantCode]=[dbo].[Patiants].[Code]
	where @date=[dbo].[Updatings].[UpdateDate] and @id=[dbo].[Patiants].[Id]
end


GO
