USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[getPastGeniclogiById]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getPastGeniclogiById](@id varchar(9)) as
begin
select *
from [dbo].[PastGenicology] join [dbo].[Updatings]
on [dbo].[PastGenicology].[UpdateCode]=[dbo].[Updatings].[Code]
join [dbo].[Patiants] 
on [dbo].[Updatings].[PatiantCode]=[dbo].[Patiants].[Code]
where @id=[dbo].[Patiants].[Id]
end


GO
