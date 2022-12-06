namespace Day1;

public class App
{
    public void Run()
    {
        var input = File.ReadAllText(@"Input.txt");
        Console.WriteLine(PartOne(input));
        Console.WriteLine(PartTwo(input));
    }

    public int PartOne(string input)
    {
        var groups = elfGroups(input);
        return groups.Max();
    }

    public int PartTwo(string input)
    {
        var groups = elfGroups(input);
        return groups.OrderByDescending(x => x).Take(3).Sum();
    }

    public IEnumerable<int> elfGroups(string input)
    {
        return input.Split("\n\n")
            .Select(x => x.Split("\n").
            Select(line => int.Parse(line)).Sum());
    }
}