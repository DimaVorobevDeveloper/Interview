using Interview.WebApiWithRedis;
using Interview.WebApiWithRedis.Model;
using Interview.WebApiWithRedis.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// внедрение зависимости Entity Framework
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlite("Data Source=usercacheapp.db"));
// внедрение зависимости UserService
builder.Services.AddTransient<UserService>();
builder.Services.AddTransient<IBasketRepository, RedisBasketRepository>();
// добавление кэширования
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = "localhost";
    options.InstanceName = "local";
});

builder.Services.Configure<BasketSettings>(builder.Configuration);

builder.Services.AddSingleton<ConnectionMultiplexer>(sp => {
    var settings = sp.GetRequiredService<IOptions<BasketSettings>>().Value;
    var configuration = ConfigurationOptions.Parse(settings.ConnectionString, true);
    var connect = ConnectionMultiplexer.Connect(configuration);
    return connect;
});

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Configure the HTTP request pipeline.
app.MapGet("/user/{id}", (int id, IBasketRepository redisBasketRepository) =>
{
    var user = redisBasketRepository.GetUsers();
    if (user != null) return $"User {user.Count()}";
    return "User not found";
});
app.MapGet("/", () => "Hello World!");

await app.RunAsync();
