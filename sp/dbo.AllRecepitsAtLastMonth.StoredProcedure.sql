USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[AllRecepitsAtLastMonth]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AllRecepitsAtLastMonth]
as
begin
select *
from  [dbo].[receipt]
where [receiptDate].month() > (getdate().month())-1
end 


GO
