USE [Bishvilaych]
GO

/****** Object:  StoredProcedure [dbo].[addReceipt]    Script Date: 27/12/2018 23:01:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[addReceipt](@ReceiptDate DateTime ,@ReceiptNum int,@Sum money,@PayBy int,
@chequaNum varchar(12),@Bank int,@Brunch varchar(5),@BankAccount varchar(9),
 @CardsKind nvarchar(10),@CreditCard varchar(4),@Validity varchar(5),@Name nvarchar(30),@paymentNum int,@Id varchar(10),@myOut int out) as
 begin
 declare @for int
 declare @code int
 set @code=(select max([dbo].[receipt].[Code]) from [dbo].[receipt])+1
 set @for=(select [dbo].[Patiants].[Code] from [dbo].[Patiants] where [dbo].[Patiants].[Id]=@Id)
 insert into [dbo].[receipt]([Code],[For],[receiptDate],[receiptNum],[Sum],[PayBy],
 [chequaNum],[Bank],[Brunch],[BankAccount],[CardsKind],[CreditCard],
 [Validity],[name],[PaymentNum])
 values(@code,@for,@ReceiptDate,@ReceiptNum,@Sum,@PayBy,@chequaNum,@Bank,@Brunch,
 @BankAccount,@CardsKind,@CreditCard,@Validity,@Name,@PaymentNum)
 set @myOut=0
 end


GO

