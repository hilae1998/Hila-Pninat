USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[AddImmunization]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[AddImmunization](@patient varchar(10),@immunization varchar(50),@SDate datetime,@Year int,@Text varchar(100),@myOut int out)as
begin

declare @pat int
set @pat=(select [dbo].[Patiants].[Code]
from  [dbo].[Patiants]
where  [Id]=@patient
)
insert into[dbo].[Screenings]
([PatientCode],[immunization],[SDate],[Year],[Text]) 
values(@pat,@immunization,@SDate,@Year,@Text)
set @myOut=0
end


GO
