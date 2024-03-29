﻿namespace Interview.Services.Patterns.Observer;

public class ConcreteObservable : IObservable
{
    private List<IObserver> observers;

    public ConcreteObservable()
    {
        observers = new List<IObserver>();
    }

    public void AddObserver(IObserver o)
    {
        observers.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        observers.Remove(o);
    }

    public void NotifyObservers()
    {
        //foreach (IObserver observer in observers)
        //    observer.Update();
    }

    public void RegisterObserver(IObserver o)
    {
        throw new NotImplementedException();
    }
}