USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[Draw_Medicine]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Draw_Medicine] as
begin
	select [Medicine]
	from [dbo].[MedicinesKind]
end


GO
