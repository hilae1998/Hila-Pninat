USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[getImmusationList]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getImmusationList] as
begin
	select[dbo].[immunizations].[Code], [dbo].[immunizations].[immunization]
	from [dbo].[immunizations]
end


GO
