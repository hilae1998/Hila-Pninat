USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[getCustomers]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[getCustomers] as
begin
select [id],[LastName]+' '+[FirstName] as 'full_name',[Phone],[Phone2],[City],[Street]
from [dbo].[Customers]
end


GO
