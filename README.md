Programming Entity Framework
---
## Init
### Create new project
```bash
$ dotnet new sln -o dotnet-ef
$ dotnet new webapi -o break-away
$ dotnet sln dotnet-ef.sln add break-away/break-away.csproj
```

### Dependencies
```bash
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.SqlServer
```

### DB Migration
```bash
$ dotnet ef migrations add InitialCreate
$ dotnet ef database update
```
