USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[SelectKupot]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[SelectKupot] as
 begin
	select [Kupah]
	from [dbo].[Kupot]
 end


GO
