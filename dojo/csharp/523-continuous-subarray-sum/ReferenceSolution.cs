public class ReferenceSolution : Solution
{
    // O(n) time. Two prefixes with the same remainder bound a subarray whose sum is a multiple of k.
    public override bool CheckSubarraySum(int[] nums, int k)
    {
        // Keep only the first index for each remainder, to get the longest span.
        var first = new Dictionary<int, int> { [0] = -1 };
        int sum = 0;
        for (int i = 0; i < nums.Length; i += 1)
        {
            sum += nums[i];
            int remainder = sum % k;
            if (!first.TryGetValue(remainder, out int j))
            {
                first[remainder] = i;
            }
            else if (i - j >= 2)
            {
                return true;
            }
        }
        return false;
    }
}
