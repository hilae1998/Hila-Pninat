USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[Print_Receipt]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Avishag
CREATE procedure [dbo].[Print_Receipt] as
begin
	select [dbo].[MedicinesKind].[Medicine],[dbo].[Medicines].[Quantity],[dbo].[Medicines].[Days],[dbo].[Medicines].[Text]
	from [dbo].[MedicinesKind] join [dbo].[Medicines]
	on [dbo].[Medicines].[Medicine]=[dbo].[MedicinesKind].[Medicine]
	
end


GO
