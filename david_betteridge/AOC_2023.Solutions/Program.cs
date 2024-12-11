using BenchmarkDotNet.Running;

class Program
{
    static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
}

// cd AOC_2023.Solutions 
//dotnet run -c Release '--filter '*Day01BenchmarkTests*'