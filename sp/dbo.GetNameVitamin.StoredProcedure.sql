USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[GetNameVitamin]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetNameVitamin](@Num NVARCHAR)as
--שליפת שם ויטמין   
begin
   
   select[Vitamin]
   from[dbo].[Vitamins]
   where [Code]=CAST( @Num AS INT)

end

--Ma'ayan Yosef


GO
