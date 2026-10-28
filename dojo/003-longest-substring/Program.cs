var tests = new (string Name, string Input, int Expected)[]
{
    ("example one", "abcabcbb", 3),
    ("example two", "bbbbb", 1),
    ("example three", "pwwkew", 3),
    ("empty string", "", 0),
    ("all unique", "abcd", 4),
    ("keep valid suffix after duplicate", "dvdf", 3),
    ("previous occurrence outside window", "abba", 2),
    ("longest window at end", "aabcdef", 6),
    ("single character", "x", 1),
    ("spaces count as characters", " ", 1),
    ("case sensitive", "aA", 2),
    ("punctuation and digits", "a1!a", 3),
    ("maximum length repeated input", new string('a', 50_000), 1),
    // Add your own cases here.
};

int failed = 0;
foreach (var (name, input, expected) in tests)
{
    try
    {
        int actual = args.Contains("--reference")
            ? new ReferenceSolution().LengthOfLongestSubstring(input)
            : new Solution().LengthOfLongestSubstring(input);
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
