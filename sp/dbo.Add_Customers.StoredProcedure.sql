USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[Add_Customers]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Add_Customers] (@Id varchar, @FristName nvarchar, @LastName nvarchar,
 @Phone varchar, @Pone2 varchar, @City nvarchar, @Street nvarchar,@myOut int out) as
begin
   insert into [dbo].[Customers]([id],[FirstName],[LastName],[Phone],[Phone2],[City],[Street])
   values (@Id, @FristName, @LastName, @Phone, @Pone2, @City, @Street)
   set @myOut=0
end


GO
