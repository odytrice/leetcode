public class ReferenceSolution : Solution
{
    // O(log n) time. Two lower-bound searches: one for the target, one just past it.
    public override int[] SearchRange(int[] nums, int target)
    {
        int Bound(bool upper)
        {
            int l = 0;
            int r = nums.Length;
            while (l < r)
            {
                int m = l + (r - l) / 2;
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
        return first == nums.Length || nums[first] != target ? [-1, -1] : [first, Bound(true) - 1];
    }
}
