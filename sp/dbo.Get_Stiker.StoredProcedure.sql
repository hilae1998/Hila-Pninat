USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[Get_Stiker]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Get_Stiker](@id varchar)as
select [BirthDate],[FirstName]+[LastName]as'full name',[Id]
from [dbo].[Patiants]
where id=[Id]


GO
