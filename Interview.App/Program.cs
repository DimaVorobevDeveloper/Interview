// See https://aka.ms/new-console-template for more information

using Interview.Services.Linq;
using Interview.Services.Patterns.Singleton;

Console.WriteLine("Hello, World!");

var snglt = Singleton.GetInstance();
snglt.Log();

List<int> list = new() { 1, 2, 3, 4, 5 };
WhereStatement.GetLessThanMaxWithConsole(list, 3, 1);

WhereStatement.GetLessThanMaxWithConsole(list, 10, 1);

WhereStatement.GetLessThanMaxWithConsole(list, 10, 2);
WhereStatement.GetLessThanMaxWithConsole(list, 10, 3);
WhereStatement.GetLessThanMaxWithConsole(list, 10, 7);

WhereStatement.GetMoreThanMinWithConsole(list, 3, 1);

WhereStatement.GetMoreThanMinWithConsole(list, 10, 1);

WhereStatement.GetMoreThanMinWithConsole(list, 10, 2);
WhereStatement.GetMoreThanMinWithConsole(list, 10, 3);
WhereStatement.GetMoreThanMinWithConsole(list, 10, 7);

WhereStatement.GetMoreThanMinWithConsole(list, 10, 10000);
