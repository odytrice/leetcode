public class ReferenceSolution : Solution
{
    // O(n) time. Grow the window to reach the target, then shrink it while it still does.
    public override int MinSubArrayLen(int target, int[] nums)
    {
        int left = 0;
        int sum = 0;
        // nums.Length + 1 is a sentinel: no window has reached the target yet.
        int best = nums.Length + 1;
        for (int right = 0; right < nums.Length; right += 1)
        {
            sum += nums[right];
            // While the window still reaches the target, record it and try a shorter one.
            while (sum >= target)
            {
                best = Math.Min(best, right - left + 1);
                sum -= nums[left];
                left += 1;
            }
        }
        // The sentinel survived, so no subarray reaches the target.
        return best > nums.Length ? 0 : best;
    }
}
