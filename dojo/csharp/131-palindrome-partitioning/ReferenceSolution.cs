public class ReferenceSolution : Solution
{
    public override IList<IList<string>> Partition(string s)
    {
        int n = s.Length; var palindrome = new bool[n, n];
        for (int i = n - 1; i >= 0; i--) for (int j = i; j < n; j++) palindrome[i, j] = s[i] == s[j] && (j - i < 2 || palindrome[i + 1, j - 1]);
        var result = new List<IList<string>>(); var path = new List<string>();
        void Search(int start)
        {
            if (start == n) { result.Add(path.ToArray()); return; }
            for (int end = start; end < n; end++) if (palindrome[start, end])
            { path.Add(s[start..(end + 1)]); Search(end + 1); path.RemoveAt(path.Count - 1); }
        }
        Search(0); return result;
    }
}
