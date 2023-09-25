# Development of a Razor Pages Application with Authentication and Entity Framework in .Net7 C#

## Create a new Razor Pages project with Individual Authentication
```
dotnet new razor -o CrudRazor -f net7.0 --auth Individual
```
## Configure Entity Framework and SQLite
### In the Package Manager Console, execute the following commands:

```
dotnet add package Microsoft.EntityFrameworkCore.Sqlite

dotnet tool install --global dotnet-ef
dotnet ef migrations add v1
dotnet ef database update
```

## Install ASP.NET Core Code Generation Tools
```
dotnet tool install -g dotnet-aspnet-codegenerator
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
```

### Create Razor Pages for Students
```
dotnet aspnet-codegenerator razorpage Create Create -m Student -dc ApplicationDbContext -sqlite --useDefaultLayout -outDir Pages/Students
dotnet aspnet-codegenerator razorpage Edit Edit -m Student -dc ApplicationDbContext -sqlite --useDefaultLayout -outDir Pages/Students
dotnet aspnet-codegenerator razorpage Delete Delete -m Student -dc ApplicationDbContext -sqlite --useDefaultLayout -outDir Pages/Students
dotnet aspnet-codegenerator razorpage Details Details -m Student -dc ApplicationDbContext -sqlite --useDefaultLayout -outDir Pages/Students
dotnet aspnet-codegenerator razorpage Index List -m Student -dc ApplicationDbContext -sqlite --useDefaultLayout -outDir Pages/Students
```
### Create Razor Pages for Premiums
```
dotnet aspnet-codegenerator razorpage Create Create -m Premium -dc ApplicationDbContext -sqlite --useDefaultLayout -outDir Pages/Premiums
dotnet aspnet-codegenerator razorpage Edit Edit -m Premium -dc ApplicationDbContext -sqlite --useDefaultLayout -outDir Pages/Premiums
dotnet aspnet-codegenerator razorpage Delete Delete -m Premium -dc ApplicationDbContext -sqlite --useDefaultLayout -outDir Pages/Premiums
dotnet aspnet-codegenerator razorpage Details Details -m Premium -dc ApplicationDbContext -sqlite --useDefaultLayout -outDir Pages/Premiums
dotnet aspnet-codegenerator razorpage Index List -m Premium -dc ApplicationDbContext -sqlite --useDefaultLayout -outDir Pages/Premiums
```

### Credits
Balta.io [Youtube Channel](https://www.youtube.com/watch?v=fmDYYsSXrKM).