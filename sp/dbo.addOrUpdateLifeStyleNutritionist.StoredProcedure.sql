USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[addOrUpdateLifeStyleNutritionist]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Tamar Dahan

CREATE procedure [dbo].[addOrUpdateLifeStyleNutritionist]
(@height float,@weight float,@bmi int,@blood varchar(7),
@pulse int,@noteat bit,@noteatt nvarchar(100),
@meals int,@fruits int, @vegetables int,@dairy bit,
@water int, @diet bit, @diett nvarchar(100), @sleeping float,
@activity bit,@dt DateTime,@id nvarchar(9),@myOut int out) as
begin

declare @code int
set @code=(select [dbo].[Updatings].[Code]
from [dbo].[Updatings] join [dbo].[Patiants] 
on [dbo].[Updatings].[PatiantCode]=[dbo].[Patiants].[Code]
where [dbo].[Patiants].[Id] =@id and
DATEADD(dd, 0, DATEDIFF(dd, 0, [dbo].[Updatings].[UpdateDate]))=DATEADD(dd, 0, DATEDIFF(dd, 0, @dt ))
/*from [dbo].[Updatings] join [dbo].[lifestyle]   
on [dbo].[lifestyle].[UpdateCode]=[dbo].[Updatings].[Code]
where [dbo].[Updatings].[UpdateDate]=@dt and [dbo].[Updatings].[PatiantCode]=@id)*/
)
if( @code!=0)
begin 
update [dbo].[lifestyle]
set [Height]=@height,[Wheight]=@weight,[BMI]=@bmi,[BloodPressure]=@blood,
[Pulse]=@pulse,[NotEat]=@noteat,[NotEatT]=@noteatt,
[Meals]=@meals,[Fruits]=@fruits,[Vegetables]=@vegetables,[Dairy]=@dairy,
[Water]=@water,[Diet]=@diet,[DietT]=@diett,[SleepingHours]=@sleeping,
[Activity]=@activity
where [dbo].[lifestyle].[UpdateCode]=@code
/*update [dbo].[Updatings]
set [UpdateDate]=@dt
*/
set @myout=0
end
/*
else

insert into [dbo].[lifestyle]([Height],[Wheight],[BMI],[BloodPressure],[Pulse],
[Meals],[NotEat],[NotEatT],
[Fruits],[Vegetables],[Dairy],[Water],
[Diet],[DietT],[SleepingHours],[Activity] )
values(@height,@weight,@bmi,@blood,@pulse,@noteat,@noteatt,
@meals,@fruits,@vegetables,@dairy,
@water,@diet,@diett,@sleeping,@activity )
set @myout=0
end
*/
end


GO
