// See https://aka.ms/new-console-template for more information
using StackExchange.Redis;
using NRedisStack;
using NRedisStack.RedisStackCommands;
using StackExchange.Redis;

//...

Console.WriteLine("Hello, World!");
ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");
IDatabase db = redis.GetDatabase();