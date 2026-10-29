public class ReferenceSolution : NumArray
{
    // O(n) setup, O(1) per query. prefix[i] is the sum of the first i values.
    private readonly int[] prefix;

    public ReferenceSolution(int[] nums) : base(nums)
    {
        // The leading 0 means a range starting at index 0 needs no special case.
        prefix = new int[nums.Length + 1];
        for (int i = 0; i < nums.Length; i += 1)
        {
            prefix[i + 1] = prefix[i] + nums[i];
        }
    }

    public override int SumRange(int left, int right)
    {
        // Everything up to right, minus everything before left.
        return prefix[right + 1] - prefix[left];
    }
}
