USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[getReceipt]    Script Date: 03/07/2018 14:01:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER procedure [dbo].[getReceipt] 
@code nvarchar(9)
as
begin
	select * 
	from [dbo].[receipt]
	where [For] = @code
end