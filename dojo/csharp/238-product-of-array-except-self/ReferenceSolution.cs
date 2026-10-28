public class ReferenceSolution : Solution
{
    public override int[] ProductExceptSelf(int[] nums)
    {
        var result = new int[nums.Length];
        int prefix = 1, suffix = 1;
        for (int i = 0; i < nums.Length; i++) { result[i] = prefix; prefix *= nums[i]; }
        for (int i = nums.Length - 1; i >= 0; i--) { result[i] *= suffix; suffix *= nums[i]; }
        return result;
    }
}
