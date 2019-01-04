USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[Add_Worker]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Add_Worker] (@Id varchar(9), @FirstName nvarchar(20),@LastName nvarchar(20), @myOut int out)as
begin
	insert into [dbo].[Workers]([Id],[FirstName] , [LastName])
	values (@Id, @FirstName, @LastName)
	set @myOut=0
end


GO
