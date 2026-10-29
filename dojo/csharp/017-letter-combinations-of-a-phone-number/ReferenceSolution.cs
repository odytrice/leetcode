public class ReferenceSolution : Solution
{
    // O(4^n) time. Extend every prefix by each letter of the next digit.
    public override IList<string> LetterCombinations(string digits)
    {
        // No digits means no combinations, not one empty combination.
        if (digits.Length == 0)
        {
            return new List<string>();
        }
        // map[d] lists the letters on phone key d.
        string[] map = ["", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"];
        // Start from one empty prefix so the first digit has something to extend.
        var result = new List<string> { "" };
        foreach (char digit in digits)
        {
            result = result.SelectMany(prefix => map[digit - '0'].Select(c => prefix + c)).ToList();
        }
        return result;
    }
}
