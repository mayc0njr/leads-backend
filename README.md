# leads-backend
A Backend API to provide management of leads

This API was created using MediatR for CQRS, using DOTNET 6.

# Configuration
The project is created with SQLite, no additional configuration is needed.
the port for connection is default to: HTTP 5400, HTTP 5401, but can be changed on appsettings.json

# How to run
first step is to run migrations, with:
```
dotnet ef database update
```
this will create a file for sqlite to manage the database.
If this process fails, it may be necessary to install entity framework tools. It can be done through CLI
```
dotnet tool install --global dotnet-ef --version 6.*
```
this will install the migrations tooling for dotnet 6

Then, run the project with:
```
dotnet run
```

Already included some examples of http requests for each of the endpoints.
