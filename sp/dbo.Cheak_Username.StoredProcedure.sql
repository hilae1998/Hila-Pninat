USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[Cheak_Username]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Cheak_Username] (@username varchar(20),@password varchar(20),@myOut int out) as
begin

if( EXISTS(select [UserName],[UserPassword] from [dbo].[Workers] 
where [dbo].[Workers].[UserName]=@username and[dbo].[Workers].[UserPassword]= @password))
set @myOut=1
else
set @myOut=0

end


GO
