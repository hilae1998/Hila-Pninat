USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[addOrUpdateVisitReason]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[addOrUpdateVisitReason](@id varchar(9) ,@date DateTime ,@GeneralWellnessCheckUp bit,@ClinicalBreastExam bit,@pap bit ,@diaphragmFitting bit ,@otherConcetraption bit ,@IssuesWithMenstrualCycle bit ,@kallah bit ,@otherReason bit ,@text varchar)as 

begin
if exists(
	select *
	from [dbo].[VisitReason] join [dbo].[Updatings]
	on [dbo].[VisitReason].[UpdateCode]=[dbo].[Updatings].[Code]
	join [dbo].[Patiants] 
	on [dbo].[Updatings].[PatiantCode]=[dbo].[Patiants].[Code]
	where [dbo].[Patiants].[Id] = @id and [dbo].[Updatings].[UpdateDate] = @date
)
update [dbo].[VisitReason]
set [GeneralCheck]= @GeneralWellnessCheckUp,
[BreastExam]=@ClinicalBreastExam,
[Pap]=@pap,
[Diaphragm]=@diaphragmFitting,
[OtherConcetraption]=@otherConcetraption,
[MenstrualCycle]=@IssuesWithMenstrualCycle,
[Kallah]=@kallah,
[OtherReason]=@otherReason,
[Text]=@text

else
begin
insert into [dbo].[VisitReason]([GeneralCheck],[BreastExam],[Pap],[Diaphragm],[OtherConcetraption],[MenstrualCycle],
[Kallah],[OtherReason],[Text])
values (@GeneralWellnessCheckUp ,@ClinicalBreastExam ,@pap ,@diaphragmFitting ,@otherConcetraption ,@IssuesWithMenstrualCycle ,@kallah ,@otherReason ,@text )
end
end 


GO
