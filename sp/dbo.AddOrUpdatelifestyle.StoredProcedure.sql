USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[AddOrUpdatelifestyle]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE procedure [dbo].[AddOrUpdatelifestyle]
(
@dt datetime,@id nvarchar(9),@alcohol bit, @alcoholt nvarchar(100), 
@smoking bit, @smoke bit, @passivesmoking bit,@passivesmokingt nvarchar(100),
@drugs bit, @drugst nvarchar(100),
@pastdrugs bit,@pastdrugst nvarchar(100), @trauma bit, @traumat nvarchar(100),
@disorderseating bit,@disorderseatingt nvarchar(100),
@pastdisorderseating bit,@pastdisorderseatingt nvarchar(100),
@anxiety bit, @anxietyt nvarchar(100), 
@bipolar bit, @bipolart nvarchar(100),
@depression bit,@depressiont nvarchar(100),
@othermentalissue bit, @othermentalissuet nvarchar(100),
@relation bit, @relationt nvarchar(100),
@ab bit, @abt nvarchar(100), @st nvarchar(100),
@MyOut int out
)
as
begin


declare @code int
set @code=(select [dbo].[Updatings].[Code]
	from [dbo].[Updatings] join [dbo].[Patiants] 
	on [dbo].[Updatings].[PatiantCode]=[dbo].[Patiants].[Code]
	where [dbo].[Patiants].[Id] = @id and  
	DATEADD(dd, 0, DATEDIFF(dd, 0, [dbo].[Updatings].[UpdateDate]))=DATEADD(dd, 0, DATEDIFF(dd, 0, @dt ))
)


if (@code !=0)
begin 
update [dbo].[lifestyle]
set [Alcohol]=@alcohol,[AlcoholT]=@alcoholt,
[Smoking]=@smoking,[Smoke]=@smoke,[PassiveSmoking]=@passivesmoking,[Passivesmokingt]=@passivesmokingt,[Drugs]=@drugs,[DrugsT]=@drugst,[PastDrugs]=@pastDrugs,[PastDrugsT]=@pastdrugst,
[Trauma]=@trauma,[TraumaT]=@traumat,[DisordersEating]=@disorderseating,[DisordersEatingT]=@disorderseatingt,
[PastDisordersEating]=@pastDisordersEating,[PastDisordersEatingT]=@pastDisordersEatingt,[Anxiety]=@anxiety,
[AnxietyT]=@anxietyt,[Bi-polar]=@bipolar,[Bi-polarT]=@bipolart,
[Depression]=@depression ,[DepressionT]=@depressiont,
[OtherMentalIssue]=@othermentalissue,[OtherMentalIssueT]=@othermentalissuet,[Relation]=@relation, 
[RelationT]=@relationt, [Ab]=@ab, [AbT]=@abt, [St]=@st
where [dbo].[lifestyle].[UpdateCode]=@code
set @MyOut=0
end

end 




GO
