public class ReferenceSolution : Solution
{
    public override int SearchInsert(int[] nums, int target)
    {
        int l = 0, r = nums.Length;
        while (l < r) { int m = l + (r - l) / 2; if (nums[m] < target) l = m + 1; else r = m; }
        return l;
    }
}
