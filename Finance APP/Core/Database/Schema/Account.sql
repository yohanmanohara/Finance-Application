CREATE TABLE [dbo].[Account]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CustomerId] INT NOT NULL, 
    [Type] NCHAR(10) NOT NULL, 
    [Balance] REAL NOT NULL, 
    [Name] NCHAR(10) NOT NULL
)
