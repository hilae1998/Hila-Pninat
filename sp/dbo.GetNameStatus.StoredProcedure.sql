USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[GetNameStatus]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetNameStatus](@Num NVARCHAR)as
--שליפת שם סטטוס   
begin

   select [Status]
   from[dbo].[Statuses] 
   where [Code]=CAST( @Num AS INT)

end

--Ma'ayan Yosef


GO
