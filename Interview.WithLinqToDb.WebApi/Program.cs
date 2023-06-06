using DataModels;
// using Interview.WithLinqToDb.Data.DbRepositories.Rds;
using Interview.WithLinqToDb.Data.Standard.DbRepositories.KPP;
using LinqToDB;
using LinqToDB.AspNet;
using LinqToDB.AspNet.Logging;
using LinqToDB.Common;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var services = builder.Services;
services.AddTransient<KppRepository>();


var connectionString = builder.Configuration.GetConnectionString(nameof(StationsKPP14DB)) ?? "Data Source=todos.db";

services.AddLinqToDBContext<StationsKPP14DB>((provider, options)
    => options
        //will configure the AppDataConnection to use
        //sqite with the provided connection string
        //there are methods for each supported database
        .UseSqlServer(connectionString)
        //default logging will log everything using the ILoggerFactory configured in the provider
        .UseDefaultLogging(provider));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

