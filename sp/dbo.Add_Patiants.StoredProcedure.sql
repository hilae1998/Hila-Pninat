USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[Add_Patiants]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Oshrit Abayov
CREATE procedure [dbo].[Add_Patiants] (@Id varchar(9), @FirstName varchar(20),@LastName varchar(20),@kupah int, @myOut int out)as
begin
	insert into [dbo].[Patiants]([Id],[FirstName] , [LastName],[kupah])
	values (@Id, @FirstName, @LastName,@kupah)	
	set @myOut = 0
end


GO
