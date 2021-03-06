USE [Bishvilaych]
GO
/****** Object:  StoredProcedure [dbo].[updatePatiants1]    Script Date: 17/07/2018 12:02:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[updatePatiants]
@id varchar(9), @fname nvarchar(15), @lname nvarchar(15), @doctor nvarchar(25), @reffered nvarchar(15), @language nvarchar(15), @city nvarchar(15), @street nvarchar(15), @phon nvarchar(15), @phon2 nvarchar(15), @fax nvarchar(15), @email nvarchar(100), @birthdate datetime, @contactexam nvarchar(100), @contactginformation nvarchar(100), @father nvarchar(20), @mother nvarchar(20), @kupa int, @maritalstatus int, @children int, @g int, @t int, @p int, @a int, @l int, @followup bit, @occapation nvarchar(100),@f bit,
@MyOut int out
as
begin
	update [dbo].[Patiants]
	set [FirstName] =  @fname, [LastName] = @lname, [Doctor] = @doctor, [reffered] = @reffered, [Language] = @language, [City] = @city, [Street] = @street, 
	[Phone] = @phon, [Phone2] = @phon2,[Fax] = @fax , [Email] = @email, [BirthDate] = @birthdate, [ContactExam] = @contactexam, [ContactGinformation] = @contactginformation,
	[FathersOrigin] = @father, [MothersOrigin] = @mother, [Kupah] = @kupa, [MaritalStatus] = @maritalstatus,[Children] = @children, [G] = @g, [T] = @t, [P] = @p, [A] = @a,
	[L] = @l, [FollowUp] = @followup, [Occupation] = @occapation, [followed up] = @f
	where [Id] = @id
	set @myout=0
end