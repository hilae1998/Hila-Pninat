USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[getLifeStyleNutritionist]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getLifeStyleNutritionist](@id varchar(9),@date DateTime) as
begin 
declare @ourresult int
exec [dbo].[openPatiant] @patiantId = @id, @result = @ourresult output
select [UpdateCode],[Height],[Wheight],[BMI],
[BloodPressure],[Pulse],
[Meals],[NotEat],[NotEatT],
[Fruits],[Vegetables],[Dairy],
[Water],[Diet],
[DietT],[SleepingHours],[Activity]
from [dbo].[lifestyle]  join [dbo].[Updatings]
on [dbo].[lifestyle].[UpdateCode]=[dbo].[Updatings].[Code]
join [dbo].[Patiants]
on [dbo].[Updatings].[PatiantCode]=[dbo].[Patiants].[Code]
where @id=[dbo].[Patiants].[Id] and 
DATEADD(dd, 0, DATEDIFF(dd, 0, [dbo].[Updatings].[UpdateDate]))=DATEADD(dd, 0, DATEDIFF(dd, 0, @date ))
end
--[dbo].[Updatings].[Updat


GO
