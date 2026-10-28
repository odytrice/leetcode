public class ReferenceSolution : Solution
{
    public override int LeastInterval(char[] tasks, int n)
    {
        var counts = new int[26]; foreach (char task in tasks) counts[task - 'A']++;
        int max = counts.Max(), tied = counts.Count(c => c == max);
        return Math.Max(tasks.Length, (max - 1) * (n + 1) + tied);
    }
}
