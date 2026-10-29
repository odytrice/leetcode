public class ReferenceSolution : Solution
{
    // O(n) time. The window may hold at most k zeros.
    public override int LongestOnes(int[] nums, int k)
    {
        int left = 0;
        int zeros = 0;
        int best = 0;
        for (int right = 0; right < nums.Length; right += 1)
        {
            // Count the zeros the window would need to flip.
            if (nums[right] == 0)
            {
                zeros += 1;
            }
            // Shrink from the left until the window is valid again.
            while (zeros > k)
            {
                if (nums[left] == 0)
                {
                    zeros -= 1;
                }
                left += 1;
            }
            // The window now has at most k zeros, so all of them can be flipped.
            best = Math.Max(best, right - left + 1);
        }
        return best;
    }
}
