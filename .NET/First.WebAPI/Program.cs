var builder = WebApplication.CreateBuilder(args);
//Service Registration

//Dependency Injection

builder.Services.AddHttpContextAccessor();

builder.Services.AddControllers();

var app = builder.Build();
//Middleware

app.MapControllers();


app.Run();