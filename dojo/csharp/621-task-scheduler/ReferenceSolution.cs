public class ReferenceSolution : Solution
{
    // O(n) time. The most frequent tasks set the frame: (max - 1) gaps of n + 1, plus the ties at the end.
    public override int LeastInterval(char[] tasks, int n)
    {
        var counts = new int[26];
        foreach (char task in tasks)
        {
            counts[task - 'A'] += 1;
        }
        int max = counts.Max();
        int tied = counts.Count(c => c == max);
        return Math.Max(tasks.Length, (max - 1) * (n + 1) + tied);
    }
}
