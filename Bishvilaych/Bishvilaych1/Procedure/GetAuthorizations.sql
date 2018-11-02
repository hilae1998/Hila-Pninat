
--הילה אלגרבלי

create procedure GetAuthorizations as --פרוצדורה השולפת את ההרשאות מרשימת ההרשאות בשביל שדה הרשאה במסך עדכון עובד 
begin
select [Authorization]
from [dbo].[Authorizations]
end
GO