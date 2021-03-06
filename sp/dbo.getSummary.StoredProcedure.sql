USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[getSummary]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[getSummary](@date datetime,@id varchar(9)) as

begin

select UpdateCode,[Mentioned],[dbo].[Summary].[FollowUp]
from [dbo].[Summary]
 inner join [dbo].[Updatings]
on [UpdateCode]=[dbo].[Updatings].[Code] 
inner join [dbo].[Patiants]
on [dbo].[Updatings].[PatiantCode]=[dbo].[Patiants].[Code]
where DATEADD(dd, 0, DATEDIFF(dd, 0,  [dbo].[Updatings].[UpdateDate]))=DATEADD(dd, 0, DATEDIFF(dd, 0,  @date))
 and [dbo].[Patiants].[Id]=@id

end



GO
