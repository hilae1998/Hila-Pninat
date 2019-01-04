USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[getLifeStyleNutritionistById]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getLifeStyleNutritionistById](@id varchar(10)) as
begin 
exec [dbo].[openPatiant]
select [Height],[Wheight],[BMI],[BloodPressure],[Pulse],
[Meals],[NotEat],[NotEatT],
[Fruits],[Vegetables],[Dairy],[Water],
[Diet],[DietT],[SleepingHours],[Activity]
from [dbo].[lifestyle] inner join [dbo].[Updatings]
on [dbo].[lifestyle].[UpdateCode]=[dbo].[Updatings].[Code]
where [PatiantCode]=@id
end


GO
