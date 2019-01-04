USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[getLifeStyleDrById]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[getLifeStyleDrById](@id varchar(9)) as
begin
select *
from  [dbo].[lifestyle] join [dbo].[Updatings]
on [dbo].[lifestyle].[UpdateCode]=[dbo].[Updatings].[Code]
join [dbo].[Patiants] 
on [dbo].[Updatings].[PatiantCode]=[dbo].[Patiants].[Code]
where @id=[dbo].[Patiants].[Id]
end



GO
