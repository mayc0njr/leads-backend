using LeadsManagement.Application;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDependencyInjection(builder.Configuration);
builder.Services.AddControllers();
builder.Services.AddResponseCaching();
var app = builder.Build();
app.UseCors(builder => builder
       .AllowAnyHeader()
       .AllowAnyMethod()
       .AllowAnyOrigin()
    );
    
app.MapControllers();
app.Run();
