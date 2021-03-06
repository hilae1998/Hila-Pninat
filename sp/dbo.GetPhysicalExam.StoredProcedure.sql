USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[GetPhysicalExam]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--ORTAL ALON
--שליפת בדיקה רפואית עפ"י תאריך ות"ז של פציינט 
CREATE procedure [dbo].[GetPhysicalExam](@date DateTime, @id nvarchar(10))  as
begin
declare @ourresult int
exec [dbo].[openPatiant] @patiantId = @id, @result = @ourresult output 
	select *
	from [dbo].[PhysicalExam] join [dbo].[Updatings]
	on [dbo].[PhysicalExam].[UpdateCode]=[dbo].[Updatings].[Code]
	join [dbo].[Patiants]
	on [dbo].[Patiants].[Code]=[dbo].[Updatings].[PatiantCode]
	where DATEADD(dd, 0, DATEDIFF(dd, 0,  [dbo].[Updatings].[UpdateDate]))=DATEADD(dd, 0, DATEDIFF(dd, 0,  @date))
	and [dbo].[Patiants].[Id]=@id
end





GO
