USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[Draw_Kupah]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Draw_Kupah] as
begin
	select [Kupah],Code
	from [dbo].[Kupot]
end


GO
