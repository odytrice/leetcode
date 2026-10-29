public class ReferenceSolution : Solution
{
    // O(log n) time. One half is always sorted; check whether the target lies in it.
    public override int Search(int[] nums, int target)
    {
        int l = 0;
        int r = nums.Length - 1;
        while (l <= r)
        {
            int m = l + (r - l) / 2;
            if (nums[m] == target)
            {
                return m;
            }
            if (nums[l] <= nums[m])
            {
                // The left half is sorted.
                if (nums[l] <= target && target < nums[m])
                {
                    r = m - 1;
                }
                else
                {
                    l = m + 1;
                }
            }
            else
            {
                // The right half is sorted.
                if (nums[m] < target && target <= nums[r])
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }
        }
        return -1;
    }
}
