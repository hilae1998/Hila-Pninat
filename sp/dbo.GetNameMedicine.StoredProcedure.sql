USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[GetNameMedicine]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetNameMedicine](@Num NVARCHAR)as
--שליפת שם תרופה   
begin
   
   select [Medicine]
   from[dbo].[MedicinesKind]
   where [Code]=CAST( @Num AS INT)

end

--Ma'ayan Yosef


GO
