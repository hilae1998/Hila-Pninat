USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[getFollowUp]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[getFollowUp] as
begin
select [FollowUp],[Code]
from [dbo].[FollowUp]
end

GO
