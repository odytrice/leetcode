public class ReferenceSolution : Solution
{
    // O(log n) time. Find the first index whose value is not below the target.
    public override int SearchInsert(int[] nums, int target)
    {
        int l = 0;
        int r = nums.Length;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (nums[m] < target)
            {
                l = m + 1;
            }
            else
            {
                r = m;
            }
        }
        return l;
    }
}
