Comandos úteis:

dotnet ef database update -c UniversityDBContext --startup-project ../Presentation/CleanArch.UI.MVC.csproj

dotnet add CleanArch.UI.MVC.csproj reference ../Infra.Data/CleanArch.Infra.Data.csproj

===========================================================================================================

SQL:

USE [UniversityDB]
GO

INSERT INTO [dbo].[Courses]
           ([Name]
           ,[Description]
           ,[ImageUrl])
     VALUES
           ('Physics'
           ,'Introduction to Physics'
           ,'/images/01.jpg')
GO

INSERT INTO [dbo].[Courses]
           ([Name]
           ,[Description]
           ,[ImageUrl])
     VALUES
           ('Chemistry'
           ,'Introduction to Chemistry'
           ,'/images/02.jpg')
GO

INSERT INTO [dbo].[Courses]
           ([Name]
           ,[Description]
           ,[ImageUrl])
     VALUES
           ('Mathematics'
           ,'Introduction to Mathematics'
           ,'/images/03.jpg')
GO

===========================================================================================================