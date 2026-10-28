var tests = new (string Name, int[][] Input, int[][] Expected)[]
{
    ("example one", [[1, 3], [2, 6], [8, 10], [15, 18]], [[1, 6], [8, 10], [15, 18]]),
    ("touching endpoints", [[1, 4], [4, 5]], [[1, 5]]),
    ("unordered and contained", [[8, 10], [1, 4], [2, 3]], [[1, 4], [8, 10]]),
    ("single interval", [[2, 5]], [[2, 5]]),
    ("separate intervals", [[1, 2], [4, 5]], [[1, 2], [4, 5]]),
    ("chain overlap", [[1, 3], [5, 8], [2, 6]], [[1, 8]]),
    ("contained interval must not shrink end", [[1, 10], [2, 3], [9, 12]], [[1, 12]]),
    ("duplicate intervals", [[2, 4], [2, 4]], [[2, 4]]),
    ("equal starts", [[1, 2], [1, 8], [1, 3]], [[1, 8]]),
    ("zero length intervals", [[3, 3], [1, 1], [3, 4]], [[1, 1], [3, 4]]),
    // Add your own cases here.
};

string Format(int[][] intervals) =>
    "[" + string.Join(", ", intervals.Select(pair => "[" + string.Join(", ", pair) + "]")) + "]";

int failed = 0;
foreach (var (name, input, expected) in tests)
{
    try
    {
        int[][] actual = args.Contains("--reference")
            ? new ReferenceSolution().Merge(input)
            : new Solution().Merge(input);
        bool matches = actual is not null
            && actual.Length == expected.Length
            && actual.Zip(expected).All(pair => pair.First is not null && pair.First.SequenceEqual(pair.Second));

        if (matches)
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
