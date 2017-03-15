Developement using below tools:
1) IDE - Visual studio 2013
2) SQL server 
3) Bootstrap template from CDN

## Getting Started

To begin using Timesheet Application following points needs to be noted
1) Folder structure needs to maintain as it is
2) Create a table -"AD_Customer" under "QMT_TEST" database in SQL Server with below details:
-------------------------------------------------------
USE [QMT_TEST]
GO


CREATE TABLE [dbo].[AD_Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [nvarchar](50) NULL,
	[From] [nvarchar](50) NULL,
	[To] [nvarchar](50) NULL,
	[Comments] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
-------------------------------------------------------
3) Insert manual entries into Table - AD_Customer like
Id	Date	        From	  To	Comments
1	Mar 14 2017  	12:30	16:30	New NLP user
2	Mar 14 2017  	14:30	18:30	New NLP user2
3	Mar 14 2017 	20:30	22:30	New NLP user3

4) Code will migrate your data model class into SQL Server database by using EF code first database migration.

5) Please let me know in case of issues on my emailid amol.deshamukh@sutherlnadglobal.com / +91 9901729408

  

## Bugs and Issues

Please feel free to reach me in case any bugs/issues found. Date and time customization using bootstrap template is pending.

## Creator

Timesheet App with CRUD (Create, Read, Update, Delete) Operations using AngularJS, ASP.NET WebAPI, Entity Framework code first and Bootstrap by AmolDesh

## Copyright and License
Sutherland digital labs
