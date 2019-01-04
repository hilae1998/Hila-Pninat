USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[UpdateWorker]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--hila elgrabli
--פרוצדורה המעדכנת את כל השדות במסך עדכון עובד חוץ משדות: שם משתמש וסיסמא
CREATE procedure [dbo].[UpdateWorker](@id varchar(9),@FirstName nvarchar(15),@LastName nvarchar(15)
,@Job int,@WokerAuthorization int,
@City nvarchar(15),@Street nvarchar(30),@Phone nvarchar(15),
@Phone2 nvarchar(15),@Fax varchar(15),@Email nvarchar(100),@BirthDate datetime,@myOut int out)as
begin
declare @myID varchar(9)

update [dbo].[Workers]
set [Job]=@Job,
[WokerAuthorization]=@WokerAuthorization,
[City]=@City,
[Street]=@Street,
[Phone]=@Phone,
[Phone2]=@Phone2,
[Fax]=@Fax,
[Email]=@Email,
[BirthDate]=@BirthDate,
LastName=@LastName

where [dbo].[Workers].[Id]=@id
set @myOut=0
end



GO
