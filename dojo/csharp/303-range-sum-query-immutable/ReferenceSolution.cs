public class ReferenceSolution : NumArray
{
    private readonly int[] prefix;
    public ReferenceSolution(int[] nums) : base(nums)
    {
        prefix = new int[nums.Length + 1];
        for (int i = 0; i < nums.Length; i++) prefix[i + 1] = prefix[i] + nums[i];
    }
    public override int SumRange(int left, int right) => prefix[right + 1] - prefix[left];
}
