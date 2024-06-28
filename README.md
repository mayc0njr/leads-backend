# leads-backend
A Backend API to provide management of leads

This API was created using MediatR for CQRS, using DOTNET 6.

# Configuration
The project is created with SqlServer, connection string should be set on appsettings.json
a docker container can be pulled and created using
```
docker pull mcr.microsoft.com/mssql/server
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=P@ssw0rd" -p 1433:1433 --name CONTAINER_NAME -d mcr.microsoft.com/mssql/server
```
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
