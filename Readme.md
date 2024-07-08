
# Is there ever a reason to use goto in modern .NET code?

[StackOverfow question](https://stackoverflow.com/questions/2542289/is-there-ever-a-reason-to-use-goto-in-modern-net-code)

An [example](https://stackoverflow.com/a/3167847/1498252) with factorial using recursive and GOTO
implementation. I Added while implementation.

## Results

```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4529/22H2/2022Update)
12th Gen Intel Core i7-12850HX, 1 CPU, 24 logical and 16 physical cores
.NET SDK 8.0.204
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2


```

| Method | i  | Mean      | Error     | StdDev    |
|------- |--- |----------:|----------:|----------:|
| **FactR**  | **10** |  **4.586 ns** | **0.0491 ns** | **0.0410 ns** |
| FactG  | 10 |  3.237 ns | 0.0279 ns | 0.0261 ns |
| FactW  | 10 |  2.697 ns | 0.0742 ns | 0.0694 ns |
| **FactR**  | **25** | **12.913 ns** | **0.0870 ns** | **0.0814 ns** |
| FactG  | 25 |  5.612 ns | 0.0076 ns | 0.0060 ns |
| FactW  | 25 |  5.285 ns | 0.1101 ns | 0.1030 ns |
