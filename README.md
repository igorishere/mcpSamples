# Model Context Protocol (MCP) Sample Projects

This repository contains sample implementations of MCP (Model Context Protocol) servers in .NET, demonstrating both stdio and HTTP-based communication.

## Project Structure

The repository contains two main projects:

### 1. STDIOSample

A console application that implements an MCP server using stdio (standard input/output) for communication.

#### Features:
- **Car Database Tools**
  - List all cars with details (brand, engine type, etc.)
  - Filter cars by brand
  - Filter cars by engine type
- **Directory Management Tools**
  - List files in the Downloads directory
  - Clean (delete files from) the Downloads directory

#### Usage:
```bash
dotnet run --project STDIOSample/STDIOSample.csproj
```

### 2. HTTPSample

A web application that implements an MCP server over HTTP using ASP.NET Core.

#### Features:
- **Car Database Tools**
  - List all cars with details
  - Filter cars by brand
  - Filter cars by engine type

#### Usage:
```bash
dotnet run --project HTTPSample/HTTPSample.csproj
```
The server will start on http://localhost:5000 by default.

## Tools Implementation

### Car Tools
Both projects implement the following car-related tools:

- `GetAllCars`: Returns a list of all cars with their details
  - Name
  - Brand
  - Country
  - Engine type
  - Turbo information
  - Traction system

- `GetCarsEngine`: Filters cars by engine type
  - Supports: V6, V8, Inline4, Inline6, etc.

- `GetCarsByBrand`: Filters cars by brand
  - Supports: Toyota, Ford, Honda, Chevrolet, BMW, Audi, Mercedes-Benz, Volkswagen, Nissan, Hyundai

### Directory Tools (STDIOSample only)
File system management tools:

- `ListDownloadsDirectory`: Lists all files in the Downloads directory with:
  - File name
  - Extension
  - Creation time
  - Last modified time

- `CleanDownloadsDirectory`: Deletes all user files from the Downloads directory
  - Preserves system files (starting with '.')
  - Returns operation success status

## Technical Details

### Dependencies
- .NET 9.0
- ModelContextProtocol.Server (for STDIOSample)
- ModelContextProtocol.AspNetCore (for HTTPSample)

### Cross-Platform Support
Both projects are designed to work across different operating systems:
- Windows
- macOS
- Linux

### Security Considerations
- Directory tools include safety checks for system files
- Error handling for file operations
- Platform-specific path handling

## Development

### Building the Projects
```bash
# Build all projects
dotnet build

# Build specific project
dotnet build STDIOSample/STDIOSample.csproj
dotnet build HTTPSample/HTTPSample.csproj
```

### Running Tests
```bash
dotnet test
```

## MCP Protocol
These implementations follow the Model Context Protocol specification. For more details about the protocol, visit: https://modelcontextprotocol.io/llms-full.txt

## License
[Insert License Information]
