USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[CheckUserName]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CheckUserName](@usename nvarchar(10),@myOut int out)as
begin
if(EXISTS (select  [UserName] from [dbo].[Workers] where [UserName]=@usename))
  set @myOut=10
  else
  set @myOut=20


end


GO
