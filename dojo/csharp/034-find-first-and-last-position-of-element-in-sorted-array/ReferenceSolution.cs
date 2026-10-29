public class ReferenceSolution : Solution
{
    // O(log n) time. Two lower-bound searches: one for the target, one just past it.
    public override int[] SearchRange(int[] nums, int target)
    {
        // Returns the first index whose value is >= target, or > target when upper is true.
        int Bound(bool upper)
        {
            int l = 0;
            int r = nums.Length;
            while (l < r)
            {
                int m = l + (r - l) / 2;
                // Everything up to m belongs before the bound, so skip past it.
                if (nums[m] < target || (upper && nums[m] == target))
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

        int first = Bound(false);
        // If the lower bound does not hold the target, the target is missing.
        return first == nums.Length || nums[first] != target ? [-1, -1] : [first, Bound(true) - 1];
    }
}
