CREATE TABLE [dbo].[Account]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CustomerId] INT NOT NULL, 
    [Type] NCHAR(30) NOT NULL, 
    [Balance] REAL NOT NULL, 
    [Name] NCHAR(300) NOT NULL
)
