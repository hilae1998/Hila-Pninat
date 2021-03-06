USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[addOrUpdatePastGenicology]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[addOrUpdatePastGenicology](
@id1 varchar(9), @date1 DateTime, @AgeOfMenarche1 int, @CycleRegular1 bit,
@CycleRegularT1 nvarchar(100), @MenstrualSyptoms1 bit, @MenstrualSyptomsT1 nvarchar(100),
@MenopauseSyptoms1 bit, @MenopauseSyptomsT1 nvarchar(100), @Contraception1 bit, @ContraceptionT1 nvarchar(100),
@MyOut int out
)as 
begin
declare @code int
set @code=(select [dbo].[Updatings].[Code]
	from [dbo].[Updatings]
	join [dbo].[Patiants] 
	on [dbo].[Updatings].[PatiantCode]=[dbo].[Patiants].[Code]
	where [dbo].[Patiants].[Id] = @id1 and  
	DATEADD(dd, 0, DATEDIFF(dd, 0, [dbo].[Updatings].[UpdateDate]))=DATEADD(dd, 0, DATEDIFF(dd, 0, @date1 ))
)
if (@code != 0)
begin 
print '2'
update [dbo].[PastGenicology]
set [AgeOfMenarche]=@AgeOfMenarche1,[CycleRegular]=@CycleRegular1,[CycleRegularT]=@CycleRegularT1,
[MenstrualSyptoms]=@MenstrualSyptoms1,[MenstrualSyptomsT]=@MenstrualSyptomsT1,
[MenopauseSyptoms]=@MenopauseSyptoms1,[MenopauseSyptomsT]=@MenopauseSyptomsT1,
[Contraception]=@Contraception1,[ContraceptionT]=@ContraceptionT1
where [dbo].[PastGenicology].[UpdateCode]=@code
set @myout=0
end
end



GO
