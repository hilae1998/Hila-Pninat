USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[getId_Patient]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getId_Patient](@id varchar(9)) as
begin
select [Id] from [dbo].[Patiants]
where EXISTS(select [Id] from [dbo].[Patiants] where [dbo].[Patiants].[Id]=id)
end


GO
