using CodeSolveNetwork.Api;
using CodeSolveNetwork.Api.Configuration;
using CodeSolveNetwork.Common.Settings;
using CodeSolveNetwork.Services.Settings.Settings;


var mainSettings = Settings.Load<MainSettings>("Main");
var logSettings = Settings.Load<LogSettings>("Log");
var swaggerSettings = Settings.Load<SwaggerSettings>("Swagger");

var builder = WebApplication.CreateBuilder(args);

builder.AddAppLogger(mainSettings, logSettings);

// Add services to the container.

builder.Services.RegisterServices();    //adding bootstrapper services

builder.Services.AddAppAutoMappers();
builder.Services.AddAppValidator();

builder.Services.AddAppHealthChecks();

builder.Services.AddAppVersioning();

builder.Services.AddAppCors();
builder.Services.AddAppControllerAndViews();

var app = builder.Build();

app.UseAppHealthChecks();
app.UseAppCors();
app.UseAppControllerAndViews();

app.Run();
