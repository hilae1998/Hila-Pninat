USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[DeleteMedicines]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DeleteMedicines](@Code int)as--מחיקת פרטי תרופה מסויימת
begin 
   delete from [dbo].[Medicines]
   where[dbo].[Medicines].[Code]=@Code
end



GO
