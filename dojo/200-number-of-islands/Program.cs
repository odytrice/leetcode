var tests = new (string Name, string[] Input, int Expected)[]
{
    ("example one", ["11110", "11010", "11000", "00000"], 1),
    ("example two", ["11000", "11000", "00100", "00011"], 3),
    ("diagonal cells are separate", ["10", "01"], 2),
    ("single land cell", ["1"], 1),
    ("all water", ["000", "000"], 0),
    ("all land", ["111", "111"], 1),
    ("single row", ["1101001"], 3),
    ("single column", ["1", "1", "0", "1", "0", "1"], 3),
    ("maximum-size single island", Enumerable.Repeat(new string('1', 300), 300).ToArray(), 1),
    // Add your own cases here.
};

int failed = 0;
foreach (var (name, input, expected) in tests)
{
    try
    {
        char[][] grid = input.Select(row => row.ToCharArray()).ToArray();
        int actual = args.Contains("--reference")
            ? new ReferenceSolution().NumIslands(grid)
            : new Solution().NumIslands(grid);
        if (actual == expected)
        {
            Console.WriteLine($"PASS: {name}");
        }
        else
        {
            failed++;
            Console.WriteLine($"FAIL: {name}: expected {expected}, got {actual}");
        }
    }
    catch (Exception ex)
    {
        failed++;
        Console.WriteLine($"FAIL: {name}: {ex.GetType().Name}: {ex.Message}");
    }
}

Console.WriteLine($"\n{tests.Length - failed}/{tests.Length} passed.");
return failed == 0 ? 0 : 1;
