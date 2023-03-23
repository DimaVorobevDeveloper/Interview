using Interview.WebApiWithRedis;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// ��������� ����������� Entity Framework
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlite("Data Source=usercacheapp.db"));
// ��������� ����������� UserService
builder.Services.AddTransient<UserService>();
// ���������� �����������
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = "localhost";
    options.InstanceName = "local";
});

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Configure the HTTP request pipeline.
app.MapGet("/user/{id}", async (int id, UserService userService) =>
{
    User? user = await userService.GetUser(id);
    if (user != null) return $"User {user.Name}  Id={user.Id}  Age={user.Age}";
    return "User not found";
});
app.MapGet("/", () => "Hello World!");

await app.RunAsync();
