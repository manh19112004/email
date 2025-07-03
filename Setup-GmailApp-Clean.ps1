
# Script PowerShell: Setup-GmailApp.ps1

# SQL Server connection string (using Windows Authentication)
$serverName = "localhost"
$connectionString = "Server=$serverName;Database=master;Integrated Security=True;"

# 1. Connect to SQL Server (master database)
$connection = New-Object System.Data.SqlClient.SqlConnection $connectionString
$connection.Open()

# 2. Create database GmailApp if it doesn't exist
$createDbQuery = @"
IF DB_ID('GmailApp') IS NULL
BEGIN
    CREATE DATABASE GmailApp;
END
"@
$command = $connection.CreateCommand()
$command.CommandText = $createDbQuery
$command.ExecuteNonQuery()
Write-Host "Database GmailApp created if it did not exist."

# 3. Switch to GmailApp database
$connection.ChangeDatabase("GmailApp")

# 4. Create UserAccounts table if it doesn't exist
$createTableQuery = @"
IF OBJECT_ID('UserAccounts', 'U') IS NULL
BEGIN
    CREATE TABLE UserAccounts (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Email NVARCHAR(100) NOT NULL,
        Password NVARCHAR(100) NOT NULL,
        CreatedAt DATETIME DEFAULT GETDATE()
    )
END
"@
$command.CommandText = $createTableQuery
$command.ExecuteNonQuery()
Write-Host "Table UserAccounts created if it did not exist."

# 5. Insert sample data into UserAccounts
$email = "example@gmail.com"
$password = "12345678"
$insertQuery = "INSERT INTO UserAccounts (Email, Password) VALUES (@Email, @Password);"

$command = $connection.CreateCommand()
$command.CommandText = $insertQuery
$command.Parameters.Add((New-Object Data.SqlClient.SqlParameter("@Email", $email))) | Out-Null
$command.Parameters.Add((New-Object Data.SqlClient.SqlParameter("@Password", $password))) | Out-Null

$rows = $command.ExecuteNonQuery()
Write-Host "$rows row(s) inserted into UserAccounts."

# 6. Close connection
$connection.Close()
Write-Host "SQL setup completed."
