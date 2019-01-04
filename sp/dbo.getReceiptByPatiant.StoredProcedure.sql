USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[getReceiptByPatiant]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getReceiptByPatiant] (@Date datetime,@num int, @sum money) as
/*efrat ben-ezra*/
begin
select [receiptDate], [receiptNum], [Sum]
from  [dbo].[receipt]
where [receiptDate]= @Date and [receiptNum]=@num and [Sum]=@sum
end 



GO
