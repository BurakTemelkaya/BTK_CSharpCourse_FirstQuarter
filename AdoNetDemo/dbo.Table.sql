CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [UnitPrice] MONEY NOT NULL, 
    [StockAmount] INT NOT NULL
)
