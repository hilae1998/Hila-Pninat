USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[Draw_Patiants]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Draw_Patiants] as
begin
	select [Kupah]
	from [dbo].[Kupot]
end


GO
