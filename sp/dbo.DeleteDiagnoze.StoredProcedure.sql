USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[DeleteDiagnoze]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DeleteDiagnoze](@Code int)as--מחיקת פרטי אבחון מסוים
begin 
   delete from [dbo].[Diagnoze]
   where [dbo].[Diagnoze].[Code]=@Code
end


GO
