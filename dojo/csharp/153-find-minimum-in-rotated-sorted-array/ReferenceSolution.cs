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
            if (nums[m] > nums[r])
            {
                l = m + 1;
            }
            else
            {
                r = m;
            }
        }
        return nums[l];
    }
}
