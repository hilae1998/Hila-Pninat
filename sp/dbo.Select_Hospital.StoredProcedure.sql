USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[Select_Hospital]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Select_Hospital] as
begin
	select [Hospital] 
	from [dbo].[Hospitals]

end


GO
