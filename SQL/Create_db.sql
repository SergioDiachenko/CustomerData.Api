USE master;
GO
CREATE DATABASE CustomerData
ON
( NAME = CustomerData,  
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\CustomerData.mdf',
    SIZE = 10000KB,
    MAXSIZE = 20000KB,
    FILEGROWTH = 10% )  
LOG ON
( NAME = CustomerData_log,  
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\CustomerData_log.ldf',
    SIZE = 5000KB,
    MAXSIZE = 10000KB,
    FILEGROWTH = 10% );
GO