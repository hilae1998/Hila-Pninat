USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[openPatiant]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[openPatiant]
@patiantId varchar(9),
@result int out
as
begin
--אם כבר קיים עדכון להיום
if(exists(select Updatings.Code 
		  from Updatings 
		  join Patiants	
		  on Patiants.Code = Updatings.PatiantCode 
		  where Id = @patiantId and DATEADD(dd, 0, DATEDIFF(dd, 0,  UpdateDate))=DATEADD(dd, 0, DATEDIFF(dd, 0,  getdate()))))
set @result = 0
else            
begin
set @result = 1

declare @code int

begin tran
begin try
--פתיחת עדכון להיום
insert into Updatings(PatiantCode, UpdateDate)
select Patiants.Code, GETDATE() from Patiants where Id = @patiantId

set @code = @@IDENTITY

insert into VisitReason(UpdateCode)
values (@code)

insert into PastGenicology(UpdateCode)
values (@code)

insert into LifeStyle(UpdateCode)
values (@code)

insert into PhysicalExam(UpdateCode)
values (@code)

insert into Summary(UpdateCode, FollowUp)
values (@code, 1)

commit tran
end try
begin catch
set @result = 2
rollback tran
end catch
end
end


GO
