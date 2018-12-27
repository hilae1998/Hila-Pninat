USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[GetNameDiagnoze]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetNameDiagnoze](@Num NVARCHAR)as
--שליפת שם אבחנה   
begin

   select [Diagnoze]
   from [dbo].[DiagnozesKinds]
   where [Code]=CAST( @Num AS INT)

end


GO
