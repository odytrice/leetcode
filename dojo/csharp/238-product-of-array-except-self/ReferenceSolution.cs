public class ReferenceSolution : Solution
{
    // O(n) time, O(1) extra space. Multiply the product to the left by the product to the right.
    public override int[] ProductExceptSelf(int[] nums)
    {
        var result = new int[nums.Length];
        int prefix = 1;
        int suffix = 1;
        // Pass 1: result[i] is the product of everything left of i.
        for (int i = 0; i < nums.Length; i += 1)
        {
            result[i] = prefix;
            // Update after storing, so nums[i] is not part of its own product.
            prefix *= nums[i];
        }
        // Pass 2: multiply in the product of everything right of i.
        for (int i = nums.Length - 1; i >= 0; i -= 1)
        {
            result[i] *= suffix;
            suffix *= nums[i];
        }
        return result;
    }
}
