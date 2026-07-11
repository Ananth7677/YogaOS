# YogaOS

A minimal ASP.NET Core web application built on .NET 10.

## Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download)

## Getting Started

Clone the repository and restore dependencies:

```bash
git clone <repository-url>
cd YogaOS
dotnet restore
```

## Running

Run the application from the solution root:

```bash
dotnet run --project YogaOS
```

By default the app is available at:

- HTTP: http://localhost:5277
- HTTPS: https://localhost:7030

To run with the HTTPS profile:

```bash
dotnet run --project YogaOS --launch-profile https
```

Hit the root endpoint to verify it's working:

```bash
curl http://localhost:5277/
# Hello World!
```

## Project Structure

```
YogaOS.sln              Solution file
YogaOS/
  Program.cs            Application entry point and endpoint routing
  YogaOS.csproj         Project file (net10.0)
  appsettings.json      Application configuration
  Properties/
    launchSettings.json Launch profiles (http/https)
```

## Building

```bash
dotnet build
```

## License

TBD
