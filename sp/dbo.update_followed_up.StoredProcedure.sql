USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[update_followed_up]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[update_followed_up] as
begin
update [dbo].[Patiants]
set [followed up]='0'
where [followed up]='1'
end


GO
