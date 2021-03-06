USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[addOrUpdateReccomendations]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--hila elgrabli
--פרוצדורה שבודקת אם כבר התווסף סיכום הביקור להיום
--אם כן רק מעדכנת את השינויים
--אם לא,מוסיפה רשומה  חדשה לסיכום הביקור להיום

CREATE procedure [dbo].[addOrUpdateReccomendations](@id varchar(9),@code int,@rec nvarchar(100), @myout int out) as

begin

declare @date datetime
set @date=getdate()


if(EXISTS (
	select [dbo].[Reccomendations].[Code],[Reccomendation]
	from [dbo].[Reccomendations]
	 inner join [dbo].[Updatings]
	on [UpdateCode]=[dbo].[Updatings].[Code] 
	inner join [dbo].[Patiants]
	on [dbo].[Updatings].[PatiantCode]=[dbo].[Patiants].[Code]
	where [dbo].[Updatings].[UpdateDate]=@date and [dbo].[Patiants].[Id]=@id)
)
begin
declare @mycode int
set @mycode=(
		select [dbo].[Updatings].[Code]
		from [dbo].[Updatings]
		inner join [dbo].[Patiants]
		on [dbo].[Updatings].[PatiantCode]=[dbo].[Patiants].[Code]
		where [dbo].[Updatings].[UpdateDate]=@date and [dbo].[Patiants].[Id]=@id)


	update [dbo].[Reccomendations]
	set [dbo].[Reccomendations].[Code]= @code,
	[dbo].[Reccomendations].[Reccomendation]= @rec
	where [dbo].[Reccomendations].[UpdateCode]=@mycode

end

else --רשומה חדשה לסיכום הביקור
insert into [dbo].[Reccomendations]([Code],[Reccomendation]) values(@code,@rec)

set @myout = 0

end




GO
