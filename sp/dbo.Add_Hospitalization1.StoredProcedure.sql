USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[Add_Hospitalization1]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure[dbo].[Add_Hospitalization1] as
begin
	update [dbo].[Add_Hospitalization]
	set [Hospital]=(select [Hospital] from [dbo].[Hospitals])
	                                  
end 


GO
