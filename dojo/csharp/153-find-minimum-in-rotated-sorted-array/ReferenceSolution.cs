public class ReferenceSolution : Solution
{
    // O(log n) time. Compare with the right end to tell which side holds the drop.
    public override int FindMin(int[] nums)
    {
        int l = 0;
        int r = nums.Length - 1;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            // m is above the right end, so the drop to the minimum lies right of m.
            if (nums[m] > nums[r])
            {
                l = m + 1;
            }
            else
            {
                // nums[m..r] is sorted, so the minimum is at m or to its left.
                r = m;
            }
        }
        // l and r have met at the minimum.
        return nums[l];
    }
}
