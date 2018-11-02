--Lea Amsalem
-- 10/5/18

create procedure update_followed_up as
begin
update [dbo].[Patiants]
set [followed up]='0'
where [followed up]='1'
end