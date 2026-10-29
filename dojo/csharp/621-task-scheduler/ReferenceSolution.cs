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
        // The top task runs max times, needing max - 1 blocks of n + 1 slots between runs.
        int max = counts.Max();
        // Every task tied for the top count adds one slot after the last block.
        int tied = counts.Count(c => c == max);
        // With enough other tasks to fill every gap, there is no idle time at all.
        return Math.Max(tasks.Length, (max - 1) * (n + 1) + tied);
    }
}
