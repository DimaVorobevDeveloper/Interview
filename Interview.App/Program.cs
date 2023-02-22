// See https://aka.ms/new-console-template for more information

using Interview.Services.Patterns.Singleton;

Console.WriteLine("Hello, World!");

var snglt = Singleton.getInstance();
snglt.Log();
