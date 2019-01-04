USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[Add_Sensitivities]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Add_Sensitivities](
@Kind nvarchar,
@Sensitivity int,
@Medicine int,
@Influenss nvarchar,
@DesicionDate datetime,
@Desided nvarchar
)
as
begin
	insert into [dbo].[Sensitivities]
	([Kind], [Sensitivity], [Medicine], [Influenss], [DesicionDate], [Desided])
	values 
	(@Kind, @Sensitivity, @Medicine, @Influenss, @DesicionDate, @Desided)
end


GO
