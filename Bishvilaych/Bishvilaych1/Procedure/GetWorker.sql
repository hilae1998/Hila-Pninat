--created by hila elgrabli
--פרוצדורה לשליפה של כל השדות במסך עדכון עובד
--כדי שכאשר אני נכנסת לעדכון עובד מסויים הפרטים יופיעו שם
create procedure GetWorker(@id varchar(9), @myout int out)as
begin
select 
[Job],
[WokerAuthorization],
	   [City]	,			
	   [Street]	,		
	   [Phone]	,			
	   [Phone2]	,		
	   [Fax]	,			
	   [Email]	,			
	   [BirthDate]
 from [dbo].[Workers]
 where [Id]=@id
 end
	   			