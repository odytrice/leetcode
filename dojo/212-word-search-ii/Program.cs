using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example and restored", () => { char[][] b = [['a', 'b'], ['c', 'd']]; Set(new[] { "ab", "ac" }, s.FindWords(b, ["ab", "ac", "ad"])); Sequence(new[] { "ab", "cd" }, b.Select(x => new string(x))); });
Test("multiple paths one result", () => Set(new[] { "aa" }, s.FindWords([['a', 'a'], ['a', 'a']], ["aa"])));
Test("prefix words and no reuse", () => Set(new[] { "a", "ab" }, s.FindWords([['a', 'b']], ["a", "ab", "aba"])));
Test("seeded cases against individual word search", () =>
{
    var random = new Random(212);
    for (int trial = 0; trial < 50; trial++)
    {
        var b = Enumerable.Range(0, 3).Select(_ => Enumerable.Range(0, 3).Select(_ => (char)('a' + random.Next(3))).ToArray()).ToArray();
        var words = Enumerable.Range(0, 30).Select(_ => new string(Enumerable.Range(0, random.Next(1, 6)).Select(_ => (char)('a' + random.Next(3))).ToArray())).Distinct().ToArray();
        bool Exists(string word)
        {
            bool Search(int r, int c, int i, int mask)
            {
                if (r < 0 || c < 0 || r >= 3 || c >= 3 || (mask & (1 << (r * 3 + c))) != 0 || b[r][c] != word[i]) return false;
                if (i == word.Length - 1) return true;
                mask |= 1 << (r * 3 + c);
                return Search(r - 1, c, i + 1, mask) || Search(r + 1, c, i + 1, mask) || Search(r, c - 1, i + 1, mask) || Search(r, c + 1, i + 1, mask);
            }
            for (int r = 0; r < 3; r++) for (int c = 0; c < 3; c++) if (Search(r, c, 0, 0)) return true;
            return false;
        }
        var expected = words.Where(Exists).ToArray();
        Set(expected, s.FindWords(b, words));
    }
});
return Finish();
