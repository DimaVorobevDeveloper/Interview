namespace Interview.Services.WorkWithInheritance;

interface I
{
    void G();
}

class A1
{
    public void G(){}
}

class B1 : A1, I
{
    public static void Main(){}
}

public class WithInterface
{

}