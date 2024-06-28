using System.Reflection;
using LeadsManagement.Application.Interfaces;
using LeadsManagement.Repository;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
builder.Services.AddDbContext<ApplicationDbContext>();


builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();
app.Run();
