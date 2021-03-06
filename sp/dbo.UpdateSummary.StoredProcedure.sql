USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[UpdateSummary]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[UpdateSummary](@date datetime,@id varchar(9),@Mentioned bit,@FollowUp int, @myOut int out) as

--hila elgrabli
begin
 exec openPatiant @id,@myOut out

declare @mycode int

set @mycode=(
		select [dbo].[Updatings].[Code]
		from [dbo].[Updatings]
		inner join [dbo].[Patiants]
		on [dbo].[Updatings].[PatiantCode]=[dbo].[Patiants].[Code]
		where DATEADD(dd, 0, DATEDIFF(dd, 0,  [dbo].[Updatings].[UpdateDate]))=DATEADD(dd, 0, DATEDIFF(dd, 0,  @date))
		 and [dbo].[Patiants].[Id]=@id)
if(@myOut=1)
begin
insert into [dbo].[Summary]([UpdateCode],Mentioned,FollowUp)
values(@mycode, @Mentioned,@FollowUp)	
end

if(@myOut=0)
begin
update [dbo].[Summary]
set [Mentioned]=@Mentioned,[FollowUp]=@FollowUp
where [UpdateCode]=@mycode
end

end

GO
