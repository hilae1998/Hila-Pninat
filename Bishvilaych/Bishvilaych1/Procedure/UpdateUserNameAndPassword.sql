
--���� �������
--�������� ������� �� �� ������ ������� ���� ����� ����,��� �� ������ ������� ��� �� ������ ����� ���� ������
alter procedure UpdateUserNameAndPassword(@id varchar(9),@UserName binary(50),@UserPassword binary(50), @myout int out)as
begin


if(EXISTS (select [UserName] from [dbo].[Workers] where [UserName]=@UserName))
	set @myout=1--�� �����-�� ����� ���� ������
else
update [dbo].[Workers]
set [UserName]=@UserName,[UserPassword]=UserPassword
where [Id]=@id
set @myout=0--�����
end
GO