﻿namespace Interview.Services.Patterns.Decorator;

// Декоратор(Decorator) представляет структурный шаблон проектирования, который позволяет динамически подключать к объекту дополнительную функциональность.
// Для определения нового функционала в классах нередко используется наследование.Декораторы же предоставляет наследованию более гибкую альтернативу,
// поскольку позволяют динамически в процессе выполнения определять новые возможности у объектов.
// Когда следует использовать декораторы?
// Когда надо динамически добавлять к объекту новые функциональные возможности.При этом данные возможности могут быть сняты с объекта
// Когда применение наследования неприемлемо. Например, если нам надо определить множество различных функциональностей
// и для каждой функциональности наследовать отдельный класс, то структура классов может очень сильно разрастись.Еще больше она может разрастись,
// если нам необходимо создать классы, реализующие все возможные сочетания добавляемых функциональностей.
abstract class Component
{
    public abstract void Operation();
}

class ConcreteComponent : Component
{
    public override void Operation()
    { }
}

abstract class Decorator : Component
{
    protected Component component;

    public void SetComponent(Component component)
    {
        this.component = component;
    }

    public override void Operation()
    {
        if (component != null)
            component.Operation();
    }
}

class ConcreteDecoratorA : Decorator
{
    public override void Operation()
    {
        base.Operation();
    }
}

class ConcreteDecoratorB : Decorator
{
    public override void Operation()
    {
        base.Operation();
    }
}