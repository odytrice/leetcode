public class ReferenceSolution : Solution
{
    // O(n) time, O(1) space. At each house, either skip it or rob it plus the best from two back.
    public override int Rob(int[] nums)
    {
        // best is the most robbed up to the last house; previous is the same one house earlier.
        int previous = 0;
        int best = 0;
        foreach (int n in nums)
        {
            int next = Math.Max(best, previous + n);
            // Slide both values forward one house.
            previous = best;
            best = next;
        }
        return best;
    }
}
