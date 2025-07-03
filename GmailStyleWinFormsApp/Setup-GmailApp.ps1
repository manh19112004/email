Windows PowerShell
Copyright (C) Microsoft Corporation. All rights reserved.

Install the latest PowerShell for new features and improvements! https://aka.ms/PSWindows

PS C:\Users\Admin> # Script PowerShell: Setup-GmailApp.ps1
PS C:\Users\Admin>
PS C:\Users\Admin> # Cấu hình chuỗi kết nối tới SQL Server (sử dụng Windows Authentication)
PS C:\Users\Admin> $serverName = "localhost"
PS C:\Users\Admin> $connectionString = "Server=$serverName;Database=master;Integrated Security=True;"
PS C:\Users\Admin>
PS C:\Users\Admin> # 1. Kết nối đến SQL Server (Database: master)
PS C:\Users\Admin> $connection = New-Object System.Data.SqlClient.SqlConnection $connectionString
PS C:\Users\Admin> $connection.Open()
PS C:\Users\Admin>
PS C:\Users\Admin> # 2. Tạo database GmailApp nếu chưa có
PS C:\Users\Admin> $createDbQuery = @"
>> IF DB_ID('GmailApp') IS NULL
>> BEGIN
>>     CREATE DATABASE GmailApp;
>> END
>> "@
PS C:\Users\Admin> $command = $connection.CreateCommand()
PS C:\Users\Admin> $command.CommandText = $createDbQuery
PS C:\Users\Admin> $command.ExecuteNonQuery()
-1
PS C:\Users\Admin> Write-Host "✅ Database GmailApp đã được tạo (nếu chưa tồn tại)."
✅ Database GmailApp đã được tạo (nếu chưa tồn tại).
PS C:\Users\Admin>
PS C:\Users\Admin> # 3. Đổi kết nối sang database GmailApp
PS C:\Users\Admin> $connection.ChangeDatabase("GmailApp")
PS C:\Users\Admin>
PS C:\Users\Admin> # 4. Tạo bảng UserAccounts nếu chưa có
PS C:\Users\Admin> $createTableQuery = @"
>> IF OBJECT_ID('UserAccounts', 'U') IS NULL
>> BEGIN
>>     CREATE TABLE UserAccounts (
>>         Id INT IDENTITY(1,1) PRIMARY KEY,
>>         Email NVARCHAR(100) NOT NULL,
>>         Password NVARCHAR(100) NOT NULL,
>>         CreatedAt DATETIME DEFAULT GETDATE()
>>     )
>> END
>> "@
PS C:\Users\Admin> $command.CommandText = $createTableQuery
PS C:\Users\Admin> $command.ExecuteNonQuery()
-1
PS C:\Users\Admin> Write-Host "✅ Bảng UserAccounts đã được tạo (nếu chưa tồn tại)."
✅ Bảng UserAccounts đã được tạo (nếu chưa tồn tại).
PS C:\Users\Admin>
PS C:\Users\Admin> # 5. Chèn dữ liệu mẫu vào bảng UserAccounts
PS C:\Users\Admin> $email = "example@gmail.com"
PS C:\Users\Admin> $password = "12345678"
PS C:\Users\Admin> $insertQuery = "INSERT INTO UserAccounts (Email, Password) VALUES (@Email, @Password);"
PS C:\Users\Admin>
PS C:\Users\Admin> $command = $connection.CreateCommand()
PS C:\Users\Admin> $command.CommandText = $insertQuery
PS C:\Users\Admin> $command.Parameters.Add((New-Object Data.SqlClient.SqlParameter("@Email", $email))) | Out-Null
PS C:\Users\Admin> $command.Parameters.Add((New-Object Data.SqlClient.SqlParameter("@Password", $password))) | Out-Null
PS C:\Users\Admin>
PS C:\Users\Admin> $rows = $command.ExecuteNonQuery()
PS C:\Users\Admin> Write-Host "✅ Đã chèn $rows dòng vào bảng UserAccounts."
✅ Đã chèn 1 dòng vào bảng UserAccounts.
PS C:\Users\Admin>
PS C:\Users\Admin> # 6. Đóng kết nối
PS C:\Users\Admin> $connection.Close()
PS C:\Users\Admin> Write-Host "`n🎉 Hoàn tất thiết lập hệ thống SQL!"

🎉 Hoàn tất thiết lập hệ thống SQL!
PS C:\Users\Admin> .\Setup-GmailApp.ps1
.\Setup-GmailApp.ps1 : The term '.\Setup-GmailApp.ps1' is not recognized as the name of a cmdlet, function, script
file, or operable program. Check the spelling of the name, or if a path was included, verify that the path is correct
and try again.
At line:1 char:1
+ .\Setup-GmailApp.ps1
+ ~~~~~~~~~~~~~~~~~~~~
    + CategoryInfo          : ObjectNotFound: (.\Setup-GmailApp.ps1:String) [], CommandNotFoundException
    + FullyQualifiedErrorId : CommandNotFoundException

PS C:\Users\Admin>
fwd-i-search: _
