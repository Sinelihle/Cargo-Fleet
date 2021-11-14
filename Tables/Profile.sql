CREATE TABLE [dbo].[Profile]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] varchar(30),
	[LastName] varchar(30),
	[Email] varchar(30),
	[PhoneNumber] varchar(10),
	[Address] varchar(60),
	[City] varchar(25),
	[Province] varchar(25),
	[ZipCode] varchar(4), 
)
