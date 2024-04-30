using OAuthServiceConnect.Models;

var builder = WebApplication.CreateBuilder(args);

var apiSettings = builder.Configuration.GetSection("oauth");
builder.Services.Configure<OauthConfig>(apiSettings);

builder.Services.AddControllers();

var app = builder.Build();
app.UseAuthorization();
app.MapControllers();
app.Run();
