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
// builder.Services.AddCors(options =>
// {
//     options.AddPolicy(name: "AllowAnyOrigin",
//                       policy  =>
//                       {
//                           policy.AllowAnyOrigin();
//                           policy.AllowAnyHeader();
//                           policy.AllowAnyMethod();
//                       });
// });
builder.Services.AddResponseCaching();
var app = builder.Build();
app.UseCors(builder => builder
       .AllowAnyHeader()
       .AllowAnyMethod()
       .AllowAnyOrigin()
    );
app.MapControllers();
app.Run();
