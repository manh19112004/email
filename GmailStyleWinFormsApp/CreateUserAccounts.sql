-- Tạo database GmailApp nếu chưa có
IF DB_ID('GmailApp') IS NULL
BEGIN
    CREATE DATABASE GmailApp;
END
GO

USE GmailApp;
GO

-- Tạo bảng UserAccounts nếu chưa có
IF OBJECT_ID('dbo.UserAccounts', 'U') IS NULL
BEGIN
    CREATE TABLE UserAccounts (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Email NVARCHAR(100) NOT NULL,
        Password NVARCHAR(100) NOT NULL,
        CreatedAt DATETIME DEFAULT GETDATE()
    );
END
GO
