USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[GetWorker]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--created by hila elgrabli
--פרוצדורה לשליפה של כל השדות במסך עדכון עובד
--כדי שכאשר אני נכנסת לעדכון עובד מסויים הפרטים יופיעו שם
CREATE procedure [dbo].[GetWorker](@id varchar(9))as
begin 
if(EXISTS (select [Id] from [dbo].[Workers] where Id=@id))
begin
select [Code],[Id],[FirstName],[LastName],[Job],[WokerAuthorization],
[City],[Street],[Phone],[Phone2],[Fax],[Email],[BirthDate]
from [dbo].[Workers]
where Id=@id
end
end



GO
