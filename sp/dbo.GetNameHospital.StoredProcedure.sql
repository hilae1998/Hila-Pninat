USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[GetNameHospital]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetNameHospital](@Num NVARCHAR)as
--שליפת שם ביה"ח   
begin

   select[Hospital]
   from[dbo].[Hospitals]
   where [Code]=CAST( @Num AS INT)

end



GO
