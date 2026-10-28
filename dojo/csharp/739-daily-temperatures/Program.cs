var tests = new (string Name, int[] Input, int[] Expected)[]
{
    ("example one", [73, 74, 75, 71, 69, 72, 76, 73], [1, 1, 4, 2, 1, 1, 0, 0]),
    ("example two", [30, 40, 50, 60], [1, 1, 1, 0]),
    ("example three", [30, 60, 90], [1, 1, 0]),
    ("single day", [70], [0]),
    ("equal temperatures", [70, 70, 70], [0, 0, 0]),
    ("visual walkthrough", [73, 71, 72, 74], [3, 1, 1, 0]),
    ("decreasing temperatures", [90, 80, 70, 60], [0, 0, 0, 0]),
    ("equal days then warmer", [70, 70, 71], [2, 1, 0]),
    ("nearest warmer day", [70, 80, 90], [1, 1, 0]),
    ("maximum length equal input", Enumerable.Repeat(70, 100_000).ToArray(), new int[100_000]),
    // Add your own cases here.
};

string Format(int[] values) => "[" + string.Join(", ", values) + "]";

int failed = 0;
foreach (var (name, input, expected) in tests)
{
    try
    {
        int[] actual = args.Contains("--reference")
            ? new ReferenceSolution().DailyTemperatures(input)
            : new Solution().DailyTemperatures(input);
        if (actual is not null && actual.SequenceEqual(expected))
        {
            Console.WriteLine($"PASS: {name}");
        }
        else
        {
            failed++;
            Console.WriteLine($"FAIL: {name}: expected {Format(expected)}, got {(actual is null ? "null" : Format(actual))}");
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
