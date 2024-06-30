# leads-backend
A Backend API to provide management of leads

This API was created using MediatR for CQRS, using DOTNET 6.

# Configuration
The project is created with SqlServer, connection string should be set on appsettings.json

if needed, a docker container can be pulled and created using `remember to set a password and user, and update the connection string data`
```
docker pull mcr.microsoft.com/mssql/server
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=P@ssw0rd" -p 1433:1433 --name CONTAINER_NAME -d mcr.microsoft.com/mssql/server
```
the port for connection is default to: HTTP 5400, HTTPS 5401, but can be changed on appsettings.json

# How to run
after the configuration is done, the first step is to run migrations, with:
```
dotnet ef database update
```
this will create the tables, and seed some data into Categories, and Contacts table
If this process fails, it may be necessary to install entity framework tools. It can be done through CLI
```
dotnet tool install --global dotnet-ef --version 6.*
```
this will install the migrations tooling for dotnet 6

Then, run the project with:
```
dotnet run
```

It is also included some examples of http requests for each of the endpoints.
