USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[addPatiants1]    Script Date: 27/12/2018 23:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[addPatiants1]
@id varchar(9), @fname nvarchar(15), @lname nvarchar(15), @doctor nvarchar(25), @reffered nvarchar(15), @language nvarchar(15), @city nvarchar(15), @street nvarchar(15), @phon nvarchar(15), @phon2 nvarchar(15), @fax nvarchar(15), @email nvarchar(100), @birthdate datetime, @contactexam nvarchar(100), @contactginformation nvarchar(100), @father nvarchar(20), @mother nvarchar(20), @kupa int, @maritalstatus int, @children int, @g int, @t int, @p int, @a int, @l int, @followup bit, @occapation nvarchar(100) 
as
begin
	insert into [dbo].[Patiants]([Id], [FirstName], [LastName], [Doctor], [reffered], [Language], [City], [Street], [Phone], [Phone2],
	[Fax], [Email], [BirthDate], [ContactExam], [ContactGinformation], [FathersOrigin], [MothersOrigin], [Kupah], [MaritalStatus],
	[Children], [G], [T], [P], [A], [L], [FollowUp], [Occupation])
	values (@id, @fname, @lname, @doctor, @reffered, @language, @city, @street, @phon, @phon2, @fax, @email, @birthdate, @contactexam, @contactginformation, @father, @mother, @kupa, @maritalstatus, @children, @g, @t, @p, @a, @l, @followup, @occapation ) 
end


GO
