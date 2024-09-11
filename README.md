# Back-End
## Prerequisites
Before you can run this project, make sure you have the following installed:
  * .NET SDK (v6.0 or higher)
  *  SQL Server (or another supported database system)
  *  Microsoft SQL Server Management Studio (SSMS) (optional, for managing SQL Server)
  *  Postman (optional, for testing API endpoints)

## Required NuGet Packages
* Microsoft.EntityFrameworkCore - Core EF functionality.
+ Microsoft.EntityFrameworkCore.SqlServer - EF Core provider for SQL Server.
- Microsoft.EntityFrameworkCore.Tools - Tools for EF Core, used for migrations and scaffolding.
+ Microsoft.AspNetCore.Authentication.JwtBearer - For JWT authentication.

## Installation
1. Clone the Repository:
   > git clone https://github.com/yourusername/yourproject.git
3. Navigate to the Project Directory:
   > cd yourproject
4. Set Up the Database:
   * Update the connection string in the GreenGoDbContext File to point to your SQL Server instance or your chosen database system.
 ```csharp
// This is a Connection String Example
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseSqlServer("Server = . ; Database = GreenGo ; Trusted_Connection =true; TrustServerCertificate = true");
}
```
5. Run Database Migrations (if using EF Core):
   * Write The Command: (Updade-DataBase) In The Project Manger Console


