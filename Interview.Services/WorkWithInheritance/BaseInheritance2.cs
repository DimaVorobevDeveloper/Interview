namespace Interview.Services.WorkWithInheritance;

public class BaseInheritance2
{
    public void Go()
    {
        Car c = new Car();
        c.Go();
        Vehicle v = new Vehicle();
        v.Go();
        v = (Vehicle)c;
        v.Go();
    }
}
class Vehicle
{
    public void Go()
    {
        Console.WriteLine("Vehicle go");
    }
}

class Car : Vehicle
{
    public void Go()
    {
        Console.WriteLine("Car go");
    }
}