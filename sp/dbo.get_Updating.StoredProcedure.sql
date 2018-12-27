USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[get_Updating]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[get_Updating](@id varchar(9)) as
begin
select [UpdateDate]
from [dbo].[Updatings] join [dbo].[Patiants]
on [dbo].[Updatings].[PatiantCode]=[dbo].[Patiants].[Code]
where [dbo].[Patiants].[Id]=@id
end

GO
