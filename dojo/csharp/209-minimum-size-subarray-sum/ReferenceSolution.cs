public class ReferenceSolution : Solution
{
    public override int MinSubArrayLen(int target, int[] nums)
    {
        int left = 0, sum = 0, best = nums.Length + 1;
        for (int right = 0; right < nums.Length; right++)
        {
            sum += nums[right];
            while (sum >= target) { best = Math.Min(best, right - left + 1); sum -= nums[left++]; }
        }
        return best > nums.Length ? 0 : best;
    }
}
