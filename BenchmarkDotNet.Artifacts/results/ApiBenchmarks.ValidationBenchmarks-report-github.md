```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.7462/24H2/2024Update/HudsonValley)
Intel Core i5-6300U CPU 2.40GHz (Max: 2.50GHz) (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method              | Mean     | Error    | StdDev   | Gen0   | Allocated |
|-------------------- |---------:|---------:|---------:|-------:|----------:|
| Net8_Invalid_Model  | 630.2 μs | 27.35 μs | 76.70 μs | 0.9766 |   2.78 KB |
| Net10_Invalid_Model | 391.2 μs |  9.40 μs | 25.58 μs | 0.9766 |   2.77 KB |
