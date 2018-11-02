--hila elgrabli
--פרוצדורה המעדכנת את כל השדות במסך עדכון עובד חוץ משדות: שם משתמש וסיסמא
create procedure UpdateWorker(@id varchar(9),@FirstName nvarchar(15),@LastName nvarchar(15)
,@Job int,@WokerAuthorization int,
@City nvarchar(15),@Street nvarchar(30),@Phone nvarchar(15),
@Phone2 nvarchar(15),@Fax varchar(15),@Email nvarchar(100),@BirthDate datetime,@myout int out)as
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
[BirthDate]=@BirthDate

where [dbo].[Workers].[Id]=@id
set @myout=0
end
GO