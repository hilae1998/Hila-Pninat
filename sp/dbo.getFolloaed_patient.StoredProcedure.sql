USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[getFolloaed_patient]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getFolloaed_patient] as
begin
select [Id],[LastName]+' '+[FirstName] as 'full_name',[Phone],[Phone2],[Kupah]
from [dbo].[Patiants]
join Updatings
on Patiants.Code = Updatings.Code
where 42>=(datediff(dd,[UpdateDate],getdate())) and ([followed up] is null or [followed up] = 0)
end


GO
