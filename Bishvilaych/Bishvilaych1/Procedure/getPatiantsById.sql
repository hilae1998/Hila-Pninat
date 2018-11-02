
--Ayala Gozlan

create procedure getPatiantsById 
@id varchar(9)
as
begin
	select * 
	from [dbo].[Patiants]
	where @id = [dbo].[Patiants].[Id]
end

