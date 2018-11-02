
--ORTAL ALON
--שליפת בדיקה רפואית עפ"י תאריך ות"ז של פציינט 
alter procedure GetPhysicalExam(@date DateTime, @id nvarchar(10))  as
begin
	select *
	from [dbo].[PhysicalExam] join [dbo].[Updatings]
	on [dbo].[PhysicalExam].[UpdateCode]=[dbo].[Updatings].[Code]
	join [dbo].[Patiants]
	on [dbo].[Patiants].[Code]=[dbo].[Updatings].[PatiantCode]
	where @date=[dbo].[Updatings].[UpdateDate] and @id=[dbo].[Patiants].[Id]
end