USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[GetAllSensitivities]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetAllSensitivities](@MyId nvarchar(9))as
--שליפת כל הרגישויות לפי ת.ז של המטופל
begin

   select [dbo].[Sensitivities].[Code],[dbo].[Sensitivities].[Kind],[dbo].[Sensitivities].[Sensitivity],
[dbo].[Sensitivities].[Medicine],[dbo].[Sensitivities].[Influenss],[dbo].[Sensitivities].[DesicionDate],
[dbo].[Sensitivities].[Desided],[dbo].[Sensitivities].[By],[dbo].[Sensitivities].[PatiantCode]
   from  [dbo].[Sensitivities]join [dbo].[Patiants]
   on[dbo].[Sensitivities].[PatiantCode]=[dbo].[Patiants].[Code]
   where [dbo].[Patiants].[Id]=@MyId

end


GO
