USE CustomerData;
GO

INSERT INTO Customer([Name], [ContactEmail], [MobileNumber]) VALUES 
(
'Lukas Medina', 'l.medina@gmail.com', '0123456789'
)

INSERT INTO TransactionData([TransactionDate], [Amount], [CurrencyCode], [Status], [CustomerId]) VALUES
(dateadd(DD, -4, getutcdate()), '99.99', 'USD', 'Success', 1),
(dateadd(DD, -3, getutcdate()), '95.99', 'USD', 'Failed', 1),
(dateadd(DD, -2, getutcdate()), '19.99', 'USD', 'Canceled', 1),
(dateadd(DD, -1, getutcdate()), '299.99', 'USD', 'Success', 1),
(getutcdate(), '999.99', 'USD', 'Success', 1)
