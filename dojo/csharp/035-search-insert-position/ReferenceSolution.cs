public class ReferenceSolution : Solution
{
    // O(log n) time. Find the first index whose value is not below the target.
    public override int SearchInsert(int[] nums, int target)
    {
        int l = 0;
        // r starts past the end because the answer may come after every element.
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
                // m might be the answer, so keep it in range.
                r = m;
            }
        }
        // l and r have met at the first value that is not below the target.
        return l;
    }
}
