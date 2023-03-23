namespace Interview.Services.WorkWithInheritance;

internal class WithSealed
{
    // будет ошибка компиляции, так как sealed запрещен к наследованию
    //sealed class A { }
    //class B : A { }
}