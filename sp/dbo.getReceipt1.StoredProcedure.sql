USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[getReceipt1]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Ayala Gozlan

create procedure [dbo].[getReceipt1] 
@code int
as
begin
	select * 
	from [dbo].[receipt]
	where [For] = @code
end


GO
