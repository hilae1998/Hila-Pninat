USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[Add_Medicines]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Add_Medicines] (
@Medicine int,
@Vitamin int,
@Active bit,
@GivenKind varchar,
@Quantity varchar,
@Days int, 
@GivenOn varchar,
@Text nvarchar
)
as
begin
	insert into [dbo].[Medicines]([Medicine], [Vitamin], [Active], [GivenKind], [Quantity], [Days], [GivenOn], [Text])
	values (@Medicine, @Vitamin, @Active, @GivenKind, @Quantity, @Days, @GivenOn, @Text)
end


GO
