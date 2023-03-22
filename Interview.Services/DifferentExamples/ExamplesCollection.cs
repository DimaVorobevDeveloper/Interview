namespace Interview.Services.DifferentExamples;

internal class ExamplesCollection
{
    // 1
    // Console.WriteLine("{0}, {1}", 1 % 3, 8 % 3); // 1,2
    // 2
    //int i = 0;
    //Console.WriteLine("aa{0}", i++); // 1,2
    //Console.WriteLine("aa{0}", i++); // 1,2
    //Console.WriteLine("bb{0}", i++); // 1,2
    //Console.WriteLine("cc{0}", i++); // 1,2
    //i += i++ + i++;
    //Console.WriteLine("13 = ?? {0}", i); // 1,2

    // 3

    //int i = 0;
    //Console.WriteLine("aa{0}", ++i); // 1
    //Console.WriteLine("cc{0}", i); // 1

    // 4
    //public abstract class SomeStruct : IDisposable
    //{
    //    public void Dispose()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    // 5
    //int i = 0;
    //Method1(i);
    //Console.WriteLine(i);

    //i = 0;
    //Method2(ref i);
    //Console.WriteLine(i);

    //i = 0;
    //Method3(out i);
    //Console.WriteLine(i);

    //static void Method1(int i)
    //{
    //    i = 111;
    //}
    //static void Method2(ref int i)
    //{
    //    i = 222;
    //}
    //static void Method3(out int i)
    //{
    //    i = 333;
    //}

    // 6 
    //LongProcess();
    //ShortProcess();


    //static async void LongProcess()
    //{
    //    Console.WriteLine("LongProcess Started");
    //    await Task.Delay(4000);
    //    Console.WriteLine("LongProcess Completed");
    //}

    //static void ShortProcess()
    //{
    //    Console.WriteLine("ShortProcess Started");
    //    Console.WriteLine("ShortProcess Completed");
    //}

    // 7 
    //        int i = 7;
    //        Console.WriteLine(i += 100000 == 0 ? 22 : 55);

    //int j = 1;
    //        Console.WriteLine(j += 0 == 0 ? 2 : 3);

    //int k = 1;
    //        Console.WriteLine(k += 1 == 0 ? 2 : 3);

    //Console.WriteLine($"{i}, {j}, {k}");

    // 8
    // int? i = null;
    // Console.WriteLine(i ?? Convert.ToInt32(i.HasValue));

    // 9 
    //sealed class A { }
    //class B : A { }

    // 10 
    //static int a = GetBVar();
    //// static int a => GetBVar();
    //static int b = 5;

    //static int GetBVar()
    //{
    //    try
    //    {
    //        return b;
    //    }
    //    finally
    //    {
    //        b = 1234;
    //        Console.Write("-----" + b);
    //    }
    //}

    // 11
    //Car c = new Car();
    //c.Go();
    //Vehicle v = new Vehicle();
    //v.Go();
    //v = (Vehicle) c;
    //v.Go();

    //class Vehicle
    //{
    //    public void Go()
    //    {
    //        Console.WriteLine("Vehicle");
    //    }
    //}

    //class Car : Vehicle
    //{
    //    public void Go()
    //    {
    //        Console.WriteLine("Car");
    //    }
    //}

    // 12
    /*
     *A a = new A(1) {i = 2};
      Console.WriteLine(a.i);
      
      class A
      {
          public int i;
      
          public A(int i)
          {
              this.i = i;
          }
              }
     */

    // 13 будет ли ошибка
    /*try
      {
          string str = null;
          Console.WriteLine(str.Length);
      }
      catch (Exception e)
      {
          Console.WriteLine("str = " + str);
      }*/

    // 14 что выведется
    /*int a = 1, b = 2;
      Swap(a, b);
      Console.WriteLine("a = {0}, b = {1}", a, b);
      
      static void Swap(int a, int b)
      {
          int c = a;
          a = b;
          b = c;
      }*/
}