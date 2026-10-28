var tests = new (string Name, int[] Nums, int K, int Expected)[]
{
    ("example one", [1, 1, 1], 2, 2),
    ("example two", [1, 2, 3], 3, 2),
    ("example three", [1, -1, 0], 0, 3),
    ("single match", [3], 3, 1),
    ("no match", [2, 4, 6], 5, 0),
    // Add your own cases here.
};

int failed = 0;
foreach (var (name, nums, k, expected) in tests)
{
    try
    {
        int actual = args.Contains("--reference")
            ? new ReferenceSolution().SubarraySum(nums, k)
            : new Solution().SubarraySum(nums, k);
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
