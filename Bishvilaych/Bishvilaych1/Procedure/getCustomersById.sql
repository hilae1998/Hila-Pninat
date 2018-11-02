create procedure getCustomersById
@id varchar(9)
as
begin
	select * 
	from [dbo].[Customers]
	where @id = [dbo].[Customers].[id]
end
