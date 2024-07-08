using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace FactorialBenchmark
{
    public class Benchmarks
    {
        // Recursive Factorial
        [Benchmark]
        [Arguments(10)]
        [Arguments(25)]
        public Int64 FactR(Int64 i)
        {
            if (i <= 1)
                return 1;
            return i * FactR(i - 1);
        }

        // Factorial using GOTO
        [Benchmark]
        [Arguments(10)]
        [Arguments(25)]
        public Int64 FactG(Int64 i)
        {
            Int64 result = 1;

        Loop:
            if (i <= 1)
                return result;

            result *= i;
            i--;
            goto Loop;
        }

        [Benchmark]
        [Arguments(10)]
        [Arguments(25)]
        public Int64 FactW(Int64 i)
        {
            Int64 result = 1;

            while (i > 1)
            {
                result *= i;
                i--;
            }
            return result;

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}
