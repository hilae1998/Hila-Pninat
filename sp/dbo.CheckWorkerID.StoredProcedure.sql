USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[CheckWorkerID]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[CheckWorkerID](@id nvarchar(9),@myOut int out)as
begin
if(EXISTS (select  [Id] from [dbo].[Workers] where Id=@id))
  set @myOut=10
  else
  set @myOut=20
end


GO
