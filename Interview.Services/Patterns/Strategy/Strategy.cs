﻿namespace Interview.Services.Patterns.Strategy;

/// <summary>
/// Паттерн Стратегия (Strategy) представляет шаблон проектирования, который определяет набор алгоритмов,
/// инкапсулирует каждый из них и обеспечивает их взаимозаменяемость.
/// В зависимости от ситуации мы можем легко заменить один используемый алгоритм другим.
/// При этом замена алгоритма происходит независимо от объекта, который использует данный алгоритм.
/// </summary>
public interface IStrategy
{
    void Algorithm();
}