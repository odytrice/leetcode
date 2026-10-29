public class ReferenceSolution : Solution
{
    // O(n) time. Only count upward from values that start a run.
    public override int LongestConsecutive(int[] nums)
    {
        // A set removes duplicates and gives O(1) lookups.
        var values = nums.ToHashSet();
        int best = 0;
        foreach (int n in values)
        {
            // n - 1 exists, so n is inside a run that will be counted from its start.
            if (values.Contains(n - 1))
            {
                continue;
            }
            int length = 1;
            // Each value is walked at most once across all runs, keeping the total O(n).
            while (values.Contains(n + length))
            {
                length += 1;
            }
            best = Math.Max(best, length);
        }
        return best;
    }
}
