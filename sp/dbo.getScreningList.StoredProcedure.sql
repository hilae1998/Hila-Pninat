USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[getScreningList]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getScreningList] as
begin
select[dbo].[ScreeningsKinds].[Code], [dbo].[ScreeningsKinds].[Screening]
from [dbo].[ScreeningsKinds]
end


GO
