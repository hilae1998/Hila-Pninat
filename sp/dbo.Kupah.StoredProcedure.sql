USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[Kupah]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Kupah](@code int) as
begin
select [dbo].[Kupot].[Kupah] from [dbo].[Kupot] join [dbo].[Patiants] on [dbo].[Kupot].[Code]=[dbo].[Patiants].[Kupah]
where [dbo].[Patiants].[Kupah]=@code
end


GO
