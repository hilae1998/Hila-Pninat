USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[getReceipt]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[getReceipt] 
@code nvarchar(9)
as
begin
	select * 
	from [dbo].[receipt]
	where [For] = @code
end


GO
