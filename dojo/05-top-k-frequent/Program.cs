var tests = new (string Name, int[] Input, int K, int[] Expected)[]
{
    ("example one", [1, 1, 1, 2, 2, 3], 2, [1, 2]),
    ("single element", [1], 1, [1]),
    ("negative values", [4, 4, 4, -1, -1, 2], 2, [4, -1]),
    ("one most frequent", [3, 2, 3, 1, 3, 2], 1, [3]),
    ("all distinct elements requested", [9, 7, 9, 5], 3, [9, 7, 5]),
    // Add your own cases here.
};

string Format(int[] values) => "[" + string.Join(", ", values) + "]";

int failed = 0;
foreach (var (name, input, k, expected) in tests)
{
    try
    {
        int[] actual = new Solution().TopKFrequent(input, k);
        bool matches = actual is not null
            && actual.Length == k
            && actual.OrderBy(value => value).SequenceEqual(expected.OrderBy(value => value));

        if (matches)
        {
            Console.WriteLine($"PASS: {name}");
        }
        else
        {
            failed++;
            Console.WriteLine($"FAIL: {name}: expected {Format(expected)} in any order, got {(actual is null ? "null" : Format(actual))}");
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
