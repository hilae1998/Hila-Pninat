USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[getReccomendations]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--hila e
CREATE procedure [dbo].[getReccomendations](@date datetime,@id varchar(9)) as

begin

select [dbo].[Reccomendations].[UpdateCode],[dbo].[Reccomendations].[Code],[Reccomendation]
from [dbo].[Reccomendations]
 inner join [dbo].[Updatings]
on [UpdateCode]=[dbo].[Updatings].[Code] 
inner join [dbo].[Patiants]
on [dbo].[Updatings].[PatiantCode]=[dbo].[Patiants].[Code]
where DATEADD(dd, 0, DATEDIFF(dd, 0,  [dbo].[Updatings].[UpdateDate]))=DATEADD(dd, 0, DATEDIFF(dd, 0,  @date))
 and [dbo].[Patiants].[Id]=@id

end


declare @a datetime
--set @a='2018-06-20 13:29:09'
set @a='2018-07-08 13:29:09.727'	
exec [dbo].[getReccomendations] @a,'311521421'


GO
