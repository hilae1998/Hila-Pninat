USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[DeleteHospitalizations]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DeleteHospitalizations](@Code int)as--מחיקת פרטי אשפוז מסוים
begin 
   delete from [dbo].[Hospitalizations]
   where[dbo].[Hospitalizations].[Code]=@Code
end


GO
