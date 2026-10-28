using System.Text.Json;

public static class TestSupport
{
    private static int total, failed;

    public static void Test(string name, Action action)
    {
        total++;
        try { action(); Console.WriteLine($"PASS: {name}"); }
        catch (Exception ex) { failed++; Console.WriteLine($"FAIL: {name}: {ex.Message}"); }
    }

    public static void Check(bool condition, string message = "Assertion failed")
    {
        if (!condition) throw new Exception(message);
    }

    public static void Equal<T>(T expected, T actual) =>
        Check(EqualityComparer<T>.Default.Equals(expected, actual), $"Expected {expected}, got {actual}");

    public static void Sequence<T>(IEnumerable<T> expected, IEnumerable<T> actual) =>
        Check(expected.SequenceEqual(actual), $"Expected {JsonSerializer.Serialize(expected)}, got {JsonSerializer.Serialize(actual)}");

    // Compare outer order independently, while still detecting duplicated results.
    public static void Set<T>(IEnumerable<T> expected, IEnumerable<T> actual) =>
        Sequence(expected.Select(x => JsonSerializer.Serialize(x)).Order(StringComparer.Ordinal),
            actual.Select(x => JsonSerializer.Serialize(x)).Order(StringComparer.Ordinal));

    public static void Rows<T>(IEnumerable<IEnumerable<T>> expected, IEnumerable<IEnumerable<T>> actual, bool sortInside = false)
    {
        string Key(IEnumerable<T> row) => JsonSerializer.Serialize(sortInside ? row.OrderBy(x => x) : row);
        Sequence(expected.Select(Key).Order(StringComparer.Ordinal), actual.Select(Key).Order(StringComparer.Ordinal));
    }

    public static int Finish()
    {
        Console.WriteLine($"\n{total - failed}/{total} passed.");
        return failed == 0 ? 0 : 1;
    }
}
