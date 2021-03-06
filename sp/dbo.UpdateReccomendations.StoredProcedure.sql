USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[UpdateReccomendations]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateReccomendations](@date datetime,@id varchar(9),@code int,@rec nvarchar(100), @myOut int out) as
--פרוצדורה לעדכון בלבד את סיכומי הביקור מתאריכים שהם לא מהיום.
--hila elgrabli
begin
 exec openPatiant @id,@myOut out

declare @mycode int
set @mycode=(
		select [dbo].[Updatings].[Code]
		from [dbo].[Updatings]
		inner join [dbo].[Patiants]
		on [dbo].[Updatings].[PatiantCode]=[dbo].[Patiants].[Code]
		where DATEADD(dd, 0, DATEDIFF(dd, 0,  [dbo].[Updatings].[UpdateDate]))=DATEADD(dd, 0, DATEDIFF(dd, 0,  @date))
		 and [dbo].[Patiants].[Id]=@id)

if(exists(select [UpdateCode],[Code]
		  from [dbo].[Reccomendations]
		  where [UpdateCode]=@mycode and [Code]=@code))
		  set @myOut=10
		  else
		  set @myOut=20
		


if(@myOut=20)
begin
insert into [dbo].[Reccomendations]([UpdateCode],[Code],[Reccomendation])
values(@mycode, @code,@rec)
	set @myOut=5
end

if(@myOut=10)
begin
update [dbo].[Reccomendations]
set [Code]=@code,[Reccomendation]=@rec
where [UpdateCode]=@mycode and [Code]=@code
set @myOut=6
end
end

GO
