public class ReferenceSolution
{
    // O(n) time and space. Count earlier prefixes whose difference is k.
    public int SubarraySum(int[] nums, int k)
    {
        // counts[s] is how many prefixes so far have sum s; the empty prefix has sum 0.
        var counts = new Dictionary<int, int> { [0] = 1 };
        int sum = 0;
        int answer = 0;
        foreach (int n in nums)
        {
            sum += n;
            // Each earlier prefix with sum - k starts a subarray that ends here and sums to k.
            answer += counts.GetValueOrDefault(sum - k);
            // Record this prefix after counting, so a subarray is never empty.
            counts[sum] = counts.GetValueOrDefault(sum) + 1;
        }
        return answer;
    }
}
