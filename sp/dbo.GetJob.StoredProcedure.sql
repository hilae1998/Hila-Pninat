USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[GetJob]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetJob] as --פרוצדורה השולפת תפקיד מרשימת התפקידים במסך עדכון עובד
begin 
select [Job],[Code]
from [dbo].[Jobs]
end 



GO
