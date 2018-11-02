--Lea Amsalem
--13/5/18

create procedure getCustomers as
begin
select [id],[LastName]+' '+[FirstName] as 'full_name',[Phone],[Phone2],[City],[Street]
from [dbo].[Customers]
end