using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace AOC_2023.Solutions;

[MemoryDiagnoser(true)]
[MarkdownExporterAttribute.GitHub]
[SimpleJob(RunStrategy.Throughput, launchCount: 1, warmupCount: 5, iterationCount: 5, id: "FastAndDirtyJob")]
public class Day01BenchmarkTests
{
    [Benchmark(Baseline = true)]
    public void Day01_Part1()
    {
        var solver = new Day01();
        var answer = solver.Part1("/Users/davidbetteridge/Personal/leeds_php/AdventOfCode2024/david_betteridge/AOC_2023.Tests/Day01/input.txt");
        if (answer != 56049) throw new Exception("Wrong answer");
    }
   
    [Benchmark(Baseline = false)]
    public void Day01_Part1_B()
    {
        var solver = new Day01();
        var answer = solver.Part1B("/Users/davidbetteridge/Personal/leeds_php/AdventOfCode2024/david_betteridge/AOC_2023.Tests/Day01/input.txt");
        if (answer != 56049) throw new Exception("Wrong answer");
    }
    
    [Benchmark(Baseline = false)]
    public void Day01_Part1_C()
    {
        var solver = new Day01();
        var answer = solver.Part1C("/Users/davidbetteridge/Personal/leeds_php/AdventOfCode2024/david_betteridge/AOC_2023.Tests/Day01/input.txt");
        if (answer != 56049) throw new Exception("Wrong answer");
    }
    
}