# leads-backend
A Backend API to provide management of leads

This API was created using MediatR for CQRS.

# Configuration
The project is created with SQLite, no additional configuration is needed.
the port for connection is default to: HTTP 5400, HTTP 5401, but can be changed on appsettings.json

# How to run
first step is to run migrations, with:
```
dotnet ef database update
```
this will create a file for sqlite to manage the database.


Then, run the project with:
```
dotnet run
```

Already included some examples of http requests for each of the endpoints.