USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[GetAllHspitalization]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetAllHspitalization](@MyId nvarchar(9))as
--שליפת כל האשפוזים לפי ת.ז של המטופל
begin

   select[dbo].[Hospitalizations].[Code],[dbo].[Hospitalizations].[Year],
   [dbo].[Hospitalizations].[Hospital],[dbo].[Hospitalizations].[Department],[dbo].[Hospitalizations].[Reason],
   [dbo].[Hospitalizations].[by],[dbo].[Hospitalizations].[PatiantCode]
   from [dbo].[Hospitalizations] join[dbo].[Patiants]
   on[dbo].[Hospitalizations].[PatiantCode]=[dbo].[Patiants].[Code]
   where [dbo].[Patiants].[Id]=@MyId

end 


GO
