USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[Update_Diagnoze]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Update_Diagnoze] (@BeginDate1 Datetime,@EndDate1 Datetime)as
begin

declare @di int
set @di=(select [Diagnoze]
	from [dbo].[Diagnoze])

declare @st int
set @st=(select [Status]
	from [dbo].[Statuses])

	update [dbo].[Add_Diagnoze]
	set
	[Diagnoze]=di,
	[Status]=st,
	 [BeginDate]=@BeginDate1,
	[EndDate]=@EndDate1
                                  
end 


GO
