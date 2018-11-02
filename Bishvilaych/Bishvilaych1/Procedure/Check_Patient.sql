--Lea Amsalem
--21/06/18

create procedure Check_Patient(@id varchar(9)) as
begin
select [Id] from [dbo].[Patiants]
where EXISTS(select [Id] from [dbo].[Patiants] where [dbo].[Patiants].[Id]=id)
end