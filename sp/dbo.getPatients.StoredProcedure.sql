USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[getPatients]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getPatients] as
begin
     select[Id],[FirstName],[LastName],[Doctor]
	 from [dbo].[Patiants]
end


GO
