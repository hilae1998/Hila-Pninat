USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[GetAllDiagnoze]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[GetAllDiagnoze](@MyId nvarchar(9))as
--שליפת כל האבחונים לפי ת.ז של המטופל
begin

   select [dbo].[Diagnoze].[Code],[dbo].[Diagnoze].[Diagnoze],[dbo].[Diagnoze].[Status],
   [dbo].[Diagnoze].[BeginDate],[dbo].[Diagnoze].[EndDate],[dbo].[Diagnoze].[By],[dbo].[Diagnoze].[PatiantCode]
   from [dbo].[Diagnoze] join [dbo].[Patiants]
   on[dbo].[Diagnoze].[PatiantCode]=[dbo].[Patiants].[Code]
   where [dbo].[Patiants].[Id]=@MyId

end


GO
