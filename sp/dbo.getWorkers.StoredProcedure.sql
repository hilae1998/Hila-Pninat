USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[getWorkers]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getWorkers] as
begin
    select [FirstName],[LastName],[Id],[Job]
	from [dbo].[Workers]
end


GO
