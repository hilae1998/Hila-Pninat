USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[GetNameWorker]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetNameWorker](@Num NVARCHAR)as
--שליפת שם עובדת   
begin

   select[LastName]+' '+[FirstName]AS'FullName'
   from[dbo].[Workers]
   where [Code]=CAST( @Num AS INT)

end


GO
