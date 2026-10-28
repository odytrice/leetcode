public class ReferenceSolution
{
    // O(n) time and space. Count earlier prefixes whose difference is k.
    public int SubarraySum(int[] nums, int k)
    {
        var counts = new Dictionary<int, int> { [0] = 1 };
        int sum = 0, answer = 0;
        foreach (int n in nums)
        {
            sum += n;
            answer += counts.GetValueOrDefault(sum - k);
            counts[sum] = counts.GetValueOrDefault(sum) + 1;
        }
        return answer;
    }
}
