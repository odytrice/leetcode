public class ReferenceSolution : Solution
{
    // O(n) time, O(1) extra space. Multiply the product to the left by the product to the right.
    public override int[] ProductExceptSelf(int[] nums)
    {
        var result = new int[nums.Length];
        int prefix = 1;
        int suffix = 1;
        for (int i = 0; i < nums.Length; i += 1)
        {
            result[i] = prefix;
            prefix *= nums[i];
        }
        for (int i = nums.Length - 1; i >= 0; i -= 1)
        {
            result[i] *= suffix;
            suffix *= nums[i];
        }
        return result;
    }
}
