USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[Add_Diagnoze]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--USE [Bishvilaych]
--GO
--/****** Object:  StoredProcedure [dbo].[Add_Diagnoze]    Script Date: 17/07/2018 13:09:23 ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
--ALTER procedure [dbo].[Add_Diagnoze] (@BeginDate1 Datetime,@EndDate1 Datetime)as
--begin
--	update [dbo].[Add_Diagnoze]
--	set [BeginDate]=@BeginDate1,
--	[EndDate]=@EndDate1 	                                 
--end

CREATE procedure [dbo].[Add_Diagnoze] (@Diagnoze int, @Status int,@BeginDate Datetime,@EndDate Datetime,@myOut int out)as
begin
	insert into [dbo].[Diagnoze]([Diagnoze],[Status],[BeginDate],[EndDate])
	values (@Diagnoze, @Status, @BeginDate,@EndDate)	
	set @myOut = 0
end 


GO
