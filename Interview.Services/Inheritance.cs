namespace Interview.Services;

public class Inheritance
{
    public static void Inh()
    {
        C c = new();
        c.DoSome(); // Console.WriteLine("С");

        B b = c;    // присвоение базовому потомка
        b.DoSome(); // и вызывается оверрайдный Console.WriteLine("B");

        A a = c;    // присвоение базовому потомка
        a.DoSome(); // и вызывается оверрайдный Console.WriteLine("B");

        C c1 = new();
        c1.DoSome(); // Console.WriteLine("С");

        B b1 = (B)c1;    // присвоение базовому потомка
        b1.DoSome(); // и вызывается оверрайдный Console.WriteLine("B");

        A a1 = (A)c1;    // присвоение базовому потомка
        a1.DoSome(); // и вызывается оверрайдный Console.WriteLine("B");
    }
}

class A
{
    public virtual void DoSome()
    {
        Console.WriteLine("A");
    }
}

class B : A
{
    public override void DoSome()
    {
        Console.WriteLine("B");
    }
}

class C : B
{
    public new void DoSome()
    {
        Console.WriteLine("C");
    }
}
