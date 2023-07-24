# EntityFrameworkQueries

## Getting Started
- Vs 2022
- .NET 6
- [AP Database](create_ap.sql) installed

You may need to change the database connection string located in the APContext class
By default it points to mssqllocaldb. If your AP script is not installed on msqllocaldb, update the string.
```csharp
optionsBuilder.UseSqlServer("Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=AP");
```
