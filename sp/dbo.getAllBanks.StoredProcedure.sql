USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[getAllBanks]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getAllBanks] as
begin
select *
from [dbo].[Banks]
end




GO
