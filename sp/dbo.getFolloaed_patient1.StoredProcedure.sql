USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[getFolloaed_patient1]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getFolloaed_patient1] as
begin
select [Id],[LastName]+' '+[FirstName] as 'full_name',[Phone],[Phone2],[Kupah]
from [dbo].[Patiants]
where 42>=(select datediff(dd,[UpdateDate],getdate()) as 'day_difference' from [dbo].[Updatings]) and [FollowUp]='1'
end



GO
