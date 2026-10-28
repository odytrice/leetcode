public class ReferenceSolution : Solution
{
    public override IList<string> LetterCombinations(string digits)
    {
        if (digits.Length == 0) return new List<string>();
        string[] map = ["", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"];
        var result = new List<string> { "" };
        foreach (char digit in digits) result = result.SelectMany(prefix => map[digit - '0'].Select(c => prefix + c)).ToList();
        return result;
    }
}
