USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[getPayBay]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getPayBay] as
begin
select *
from [dbo].[PayBy]
end


GO
