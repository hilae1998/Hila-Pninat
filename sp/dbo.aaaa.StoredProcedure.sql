USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[aaaa]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[aaaa]
( @id varchar(10),@PelvicMucosa2 int,@Kegels2 int,@myOut int out)
 as
begin
declare @date datetime,@mycode int
set @date=getdate()
set @mycode=(
		select [dbo].[Updatings].[Code]
		from [dbo].[Updatings]
		inner join [dbo].[Patiants]
		on [dbo].[Updatings].[PatiantCode]=[dbo].[Patiants].[Code]
		where DATEADD(dd, 0, DATEDIFF(dd, 0,  [dbo].[Updatings].[UpdateDate]))=DATEADD(dd, 0, DATEDIFF(dd, 0,  @date))
		 and [dbo].[Patiants].[Id]=@id)
if exists(
	select *
	from [dbo].[PhysicalExam] join [dbo].[Updatings]
	on [dbo].[PhysicalExam].[UpdateCode]=[dbo].[Updatings].[Code]
	join [dbo].[Patiants]
	on [dbo].[Updatings].[PatiantCode]=[dbo].[Patiants].[Code]
	where [dbo].[Updatings].[UpdateDate]=@date and [dbo].[Patiants].[Id]=@id)
begin	
update [dbo].[PhysicalExam]
set [Kegels]=@Kegels2,
PelvicMucosa=@PelvicMucosa2

where [UpdateCode]=@mycode
set @myOut=100
end

end 


GO
