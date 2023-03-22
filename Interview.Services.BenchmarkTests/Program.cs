// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using Interview.Services.BenchmarkTests;

//var summary = BenchmarkRunner.Run<DictionaryWithBenchmark>();
var summary = BenchmarkRunner.Run<SpanExamplesBenchmark>();
