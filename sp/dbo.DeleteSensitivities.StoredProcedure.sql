USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[DeleteSensitivities]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DeleteSensitivities](@Code int)as--מחיקת פרטי רגישות מסויימת
begin 
   delete from [dbo].[Sensitivities]
   where [dbo].[Sensitivities].[Code]=@Code
end



GO
