--Lea Amsalem
--10/5/18

create procedure getFolloaed_patient1 as
begin
select [Id],[LastName]+' '+[FirstName] as 'full_name',[Phone],[Phone2],[Kupah]
from [dbo].[Patiants]
where 42>=(select datediff(dd,[UpdateDate],getdate()) as 'day_difference' from [dbo].[Updatings]) and [FollowUp]='1'
end

