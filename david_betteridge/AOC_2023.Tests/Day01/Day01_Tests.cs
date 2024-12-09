namespace AOC_2023.Tests;

public class Day01Tests
{
    [Fact]
    public void Test_Part1_Sample()
    {
        var solver = new Day01();
        Assert.Equal(142, solver.Part1("Day01/part1_sample.txt"));
    }
    
    [Fact]
    public void Test_Part1()
    {
        var solver = new Day01();
        
        // We don't now the answer to start with
        Assert.Equal(-1234, solver.Part1("Day01/input.txt"));
    }
    
}