USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[UpdateUserNameAndPassword]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--הילה אלגרבלי
--פרוצדורה שמעדכנת את שם המשתמש והסיסמא במסך עדכון עובד,כמו כן מקיימת ולידציה האם שם המשתמש ששונה קיים במערכת
CREATE procedure [dbo].[UpdateUserNameAndPassword](@id varchar(9),@UserName nvarchar(10),@UserPassword nvarchar(10), @myOut int out)as
begin


if(EXISTS (select [UserName] from [dbo].[Workers] where [UserName]=@UserName))
	set @myOut=1--לא הצליח-שם משתמש קיים במערכת
else
update [dbo].[Workers]
set [UserName]=@UserName,[UserPassword]=@UserPassword
where [Id]=@id
set @myOut=0--הצליח
end



GO
