USE CustomerData;
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Customer')
BEGIN 
	DROP TABLE [dbo].[Customer]
END

  CREATE TABLE Customer 
  (
	  [Id] int NOT NULL PRIMARY KEY IDENTITY(1,1),
	  [Name] nvarchar(30) NOT NULL,
	  [ContactEmail] nvarchar(25) NOT NULL CONSTRAINT UK_Customer_ContactEmail UNIQUE ([ContactEmail]),
	  [MobileNumber] nvarchar(10) NOT NULL
  );
GO


IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TransactionData')
BEGIN 
	DROP TABLE dbo.TransactionData
END
  
  CREATE TABLE TransactionData 
  (
    [Id] int NOT NULL PRIMARY KEY IDENTITY(1,1),
	[TransactionDate] datetime2 NOT NULL,
	[Amount] numeric(8,2) NOT NULL,
	[CurrencyCode] nvarchar(10) NOT NULL,
	[Status] nvarchar(10) NOT NULL,
	[CustomerId] int NOT NULL 
		CONSTRAINT FK_TransactionData_CustomerId FOREIGN KEY(CustomerId) 
		REFERENCES Customer(Id) ON DELETE CASCADE	
  );
GO