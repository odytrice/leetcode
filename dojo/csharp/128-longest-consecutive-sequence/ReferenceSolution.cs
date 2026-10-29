public class ReferenceSolution : Solution
{
    // O(n) time. Only count upward from values that start a run.
    public override int LongestConsecutive(int[] nums)
    {
        var values = nums.ToHashSet();
        int best = 0;
        foreach (int n in values)
        {
            if (values.Contains(n - 1))
            {
                continue;
            }
            int length = 1;
            while (values.Contains(n + length))
            {
                length += 1;
            }
            best = Math.Max(best, length);
        }
        return best;
    }
}
