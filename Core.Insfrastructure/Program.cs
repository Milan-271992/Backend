using Microsoft.AspNetCore.Http.Extensions;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
// Add services to the container.

//builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();
builder.Services.AddHttpContextAccessor();
string basePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
builder.Configuration.SetBasePath(basePath); builder.Configuration
    .AddJsonFile($"Config/appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"Config/appsettings.{env}.json", optional: true, reloadOnChange: true);
var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

app.Run();
