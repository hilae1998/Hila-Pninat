--הילה אלגרבלי
create procedure GetJob as --פרוצדורה השולפת תפקיד מרשימת התפקידים בשביל שדה תפקיד במסך עדכון עובד
begin 
select [Job]
from [dbo].[Jobs]
end 
GO