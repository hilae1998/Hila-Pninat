USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[PatiantExist]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PatiantExist]
@id varchar(9)  
as
if exists(
			select *
			from [dbo].[Patiants]
			where [Id] = @id
		 )
		  
	return (1)
else
begin
	exec addPatiants @id
	return(0)
end


GO
