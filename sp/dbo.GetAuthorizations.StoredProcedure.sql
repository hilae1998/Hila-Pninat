USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[GetAuthorizations]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetAuthorizations] as --פרוצדורה השולפת את ההרשאות מרשימת ההרשאות בשביל שדה הרשאה במסך עדכון עובד 
begin
select [Authorization],[Code]
from [dbo].[Authorizations]
end



GO
