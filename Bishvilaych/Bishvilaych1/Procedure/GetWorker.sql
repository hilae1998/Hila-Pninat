--created by hila elgrabli
--�������� ������ �� �� ����� ���� ����� ����
--��� ����� ��� ����� ������ ���� ������ ������ ������ ��
create procedure GetWorker(@id varchar(9), @myout int out)as
begin
select 
[Job],
[WokerAuthorization],
	   [City]	,			
	   [Street]	,		
	   [Phone]	,			
	   [Phone2]	,		
	   [Fax]	,			
	   [Email]	,			
	   [BirthDate]
 from [dbo].[Workers]
 where [Id]=@id
 end
	   			