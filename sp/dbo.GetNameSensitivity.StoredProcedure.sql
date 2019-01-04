USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[GetNameSensitivity]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetNameSensitivity](@Num NVARCHAR)as
--שליפת שם רגישות כללית   
begin
   
   select[Sensitivity]
   from[dbo].[SensitivitiesKinds]
   where [Code]=CAST( @Num AS INT)
end

--Ma'ayan Yosef


GO
