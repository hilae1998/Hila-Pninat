USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[UpdateImmunizations]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[UpdateImmunizations](@name varchar(15),@date datetime,@year int, @text varchar(50))as
begin 
  update [dbo].[Screenings]
  set [immunization]= @name,[SDate]= @date,[Year]= @year,[Text]= @text
end


GO
