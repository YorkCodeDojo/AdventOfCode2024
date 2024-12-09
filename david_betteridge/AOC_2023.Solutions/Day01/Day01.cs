namespace AOC_2023.Solutions;

public class Day01
{
    public int Part1(string filename)
    {
        return 0;
    }
    
    // Working
    // public int Part1(string filename)
    // {
    //     var lines = File.ReadAllLines(filename);
    //     var total = 0;
    //     foreach (var line in lines)
    //     {
    //         var i = 0;
    //         while (!char.IsDigit(line[i]))
    //             i++;
    //         var tens = line[i] - '0';
    //
    //         var j = line.Length - 1;
    //         while (!char.IsDigit(line[j]))
    //             j--;
    //         var units = line[j] - '0';
    //
    //         total += (tens * 10) + units;
    //     }
    //
    //     return total;
    // }
    
    // Refactor
    // public int Part1(string filename)
    // {
    //     return File
    //         .ReadAllLines(filename)
    //         .Select(SolveLine)
    //         .Sum();
    // }
    //
    // private static int SolveLine(string line)
    // {
    //     var i = 0;
    //     while (!char.IsDigit(line[i]))
    //         i++;
    //     var tens = line[i] - '0';
    //
    //     var j = line.Length - 1;
    //     while (!char.IsDigit(line[j]))
    //         j--;
    //     var units = line[j] - '0';
    //
    //     return (tens * 10) + units;
    // }
}