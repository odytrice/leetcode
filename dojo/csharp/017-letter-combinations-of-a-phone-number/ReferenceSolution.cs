public class ReferenceSolution : Solution
{
    // O(4^n) time. Extend every prefix by each letter of the next digit.
    public override IList<string> LetterCombinations(string digits)
    {
        if (digits.Length == 0)
        {
            return new List<string>();
        }
        string[] map = ["", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"];
        var result = new List<string> { "" };
        foreach (char digit in digits)
        {
            result = result.SelectMany(prefix => map[digit - '0'].Select(c => prefix + c)).ToList();
        }
        return result;
    }
}
