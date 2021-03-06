USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[Get_LifeStyle]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Get_LifeStyle](@date datetime,@id varchar(9)) as
begin
declare @ourresult int
exec [dbo].[openPatiant] @patiantId = @id, @result = @ourresult output 
select [Alcohol],[AlcoholT],[Smoking],[Smoke],[PassiveSmoking],[Drugs],[PastDrugs],[Trauma],[TraumaT],[DisordersEating],[DisordersEatingT],[OtherMentalIssue],[OtherMentalIssueT],[Relation],[RelationT],[Ab],[AbT],[St]
from [dbo].[lifestyle]  join [dbo].[Updatings]
on [dbo].[lifestyle].[UpdateCode]=[dbo].[Updatings].[Code] 
join [dbo].[Patiants]
on [dbo].[Updatings].[PatiantCode]=[dbo].[Patiants].[Code]
where @id  = [dbo].[Patiants].[Id] and
DATEADD(dd, 0, DATEDIFF(dd, 0, [dbo].[Updatings].[UpdateDate]))=DATEADD(dd, 0, DATEDIFF(dd, 0, @date ))
end




GO
