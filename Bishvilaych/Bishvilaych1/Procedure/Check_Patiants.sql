USE [Bishvilaych]
GO

/****** Object:  StoredProcedure [dbo].[Check_Patient]    Script Date: 21/06/2018 18:23:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Check_Patient](@id varchar(9),@myOut int out) as
begin
if (EXISTS(select [Id] from [dbo].[Patiants] where [dbo].[Patiants].[Id]=@id))
set @myOut=0
else
set @myOut=1
end
GO

