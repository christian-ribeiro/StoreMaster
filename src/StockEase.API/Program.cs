using StockEase.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureSettings(builder.Configuration);
builder.Services.ConfigureContext(builder.Configuration);
builder.Services.ConfigureCors();
builder.Services.ConfigureAuthentication();
builder.Services.ConfigureSwagger();
builder.Services.ConfigureController();
builder.Services.ConfigureDependencyInjection();

var app = builder.Build();

app.ApplyCors();
app.ApplyAuthentication();
app.ApplySwagger();
app.ApplyController();

app.Run();