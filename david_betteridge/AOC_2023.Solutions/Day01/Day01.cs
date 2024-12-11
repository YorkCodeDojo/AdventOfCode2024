namespace AOC_2023.Solutions;

public class Day01
{
    public int Part1(string filename)
    {
        return 0;
    }
    
    
    
    
    // // Working
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
    //
    
    
    // Refactor - Functional
    public int Part1B(string filename)
    {
        return File
            .ReadAllLines(filename)
            .Select(line => (line.First(char.IsDigit) -'0') * 10 + (line.Last(char.IsDigit) -'0'))
            .Sum();
    }
    
    
    // Refactor - Single Pass
    public int Part1C(string filename)
    {
        var file = File.ReadAllBytes(filename);
        var total = 0;
        var i = 0;
        while (i < file.Length)
        {
            while (file[i] < 48 || file[i] > 57)
                i++;
            var tens = file[i] - '0';

            var units = 0;
            while (i < file.Length && file[i] != '\n')
            {
                if (file[i] >= 48 && file[i] <= 57)
                    units = file[i] - '0';
                i++;
            }

            i++;
            total += (tens * 10) + units;
        }
        return total;
    }
}