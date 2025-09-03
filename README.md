# NetBlazorApp

NetBlazorApp is a Blazor WebAssembly application built with .NET. It demonstrates modern web development using C# and Razor components.

## Features
- Weather forecast demo using dependency injection
- Responsive layout with Bootstrap
- Navigation menu and main layout
- Error handling and sample pages
- Unit tests with xUnit

## Project Structure
- `NetBlazorApp.csproj` - Main project file
- `Pages/` - Razor pages (Counter, FetchData, Index, etc.)
- `Shared/` - Shared components (MainLayout, NavMenu, etc.)
- `Data/` - Data models and services
- `wwwroot/` - Static files (CSS, images, etc.)
- `Tests/` - xUnit test project

## Getting Started
1. Install .NET SDK 7 or 8
2. Restore dependencies:
   ```
   dotnet restore
   ```
3. Build and run:
   ```
   dotnet build
   dotnet run
   ```
4. Run unit tests:
   ```
   dotnet test Tests/NetBlazorApp.Tests.csproj
   ```

## License
MIT
