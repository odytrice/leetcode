public class ReferenceSolution : Solution
{
    public override bool CheckSubarraySum(int[] nums, int k)
    {
        var first = new Dictionary<int, int> { [0] = -1 };
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i]; int remainder = sum % k;
            if (first.TryGetValue(remainder, out int j)) { if (i - j >= 2) return true; }
            else first[remainder] = i;
        }
        return false;
    }
}
