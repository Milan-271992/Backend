using System.Reflection;
using JkTyre.Business;
using JkTyre.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Get environment
var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
string basePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

// Configure configuration sources
builder.Configuration.SetBasePath(basePath)
    .AddJsonFile("Config/sharedAppsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"Config/sharedAppsettings.{env}.json", optional: true, reloadOnChange: true);

// Retrieve updated configuration object
var configuration = builder.Configuration;
//var connectionString = configuration.GetConnectionString("JkServicesConnectionString");
var connectionString = builder.Configuration.GetConnectionString("JkServicesConnectionString");

// Register DbContext with MySQL
builder.Services.AddDbContextPool<DataContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// Add services to the container
builder.Services.AddHttpContextAccessor();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
});
builder.Services.AddDistributedMemoryCache();
builder.Services.AddScoped<MasterManager>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowAll");
app.UseAuthorization();
app.MapControllers();
app.Run();
