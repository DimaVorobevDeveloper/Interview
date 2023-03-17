// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Drawing;
using System.Net;

Console.WriteLine("Hello, World!");


LongProcess();
ShortProcess();
// Console.ReadKey();


static async void LongProcess()
{
    Console.WriteLine("LongProcess Started");
    await Task.Delay(4000);
    Console.WriteLine("LongProcess Completed");
}

static void ShortProcess()
{
    Console.WriteLine("ShortProcess Started");
    Console.WriteLine("ShortProcess Completed");
}
new WebClient().Dispose();
//var snglt = Singleton.GetInstance();
//snglt.Log();

//List<int> list = new() { 1, 2, 3, 4, 5 };
//WhereStatement.GetLessThanMaxWithConsole(list, 3, 1);

//WhereStatement.GetLessThanMaxWithConsole(list, 10, 1);

//WhereStatement.GetLessThanMaxWithConsole(list, 10, 2);
//WhereStatement.GetLessThanMaxWithConsole(list, 10, 3);
//WhereStatement.GetLessThanMaxWithConsole(list, 10, 7);

//WhereStatement.GetMoreThanMinWithConsole(list, 3, 1);

//WhereStatement.GetMoreThanMinWithConsole(list, 10, 1);

//WhereStatement.GetMoreThanMinWithConsole(list, 10, 2);
//WhereStatement.GetMoreThanMinWithConsole(list, 10, 3);
//WhereStatement.GetMoreThanMinWithConsole(list, 10, 7);

//WhereStatement.GetMoreThanMinWithConsole(list, 10, 10000);

//Action<object> action = (object obj) =>
//{
//    Console.WriteLine("Task={0}, obj={1}, Thread={2}",
//        Task.CurrentId, obj,
//        Thread.CurrentThread.ManagedThreadId);
//};

//// Create a task but do not start it.
//Task t1 = new Task(action, "alpha");

//// Construct a started task
//Task t2 = Task.Factory.StartNew(action, "beta");
//// Block the main thread to demonstrate that t2 is executing
//t2.Wait();

//// Launch t1 
//t1.Start();
//Console.WriteLine("t1 has been launched. (Main Thread={0})",
//    Thread.CurrentThread.ManagedThreadId);
//// Wait for the task to finish.
//t1.Wait();

//// Construct a started task using Task.Run.
//String taskData = "delta";
//Task t3 = Task.Run(() =>
//{
//    Console.WriteLine("Task={0}, obj={1}, Thread={2}",
//        Task.CurrentId, taskData,
//        Thread.CurrentThread.ManagedThreadId);
//});
//// Wait for the task to finish.
//t3.Wait();

//// Construct an unstarted task
//Task t4 = new Task(action, "gamma");
//// Run it synchronously
//t4.RunSynchronously();
//// Although the task was run synchronously, it is a good practice
//// to wait for it in the event exceptions were thrown by the task.
//t4.Wait();