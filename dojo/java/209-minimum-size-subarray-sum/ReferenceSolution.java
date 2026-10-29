/** O(n) time, O(1) space. Shrinks the window while it still reaches the target. */
class ReferenceSolution extends Solution {
    @Override
    public int minSubArrayLen(int target, int[] nums) {
        // total is the sum of nums[left..right].
        int left = 0;
        int total = 0;
        // nums.length + 1 is an impossible length that means "nothing found yet".
        int best = nums.length + 1;
        for (int right = 0; right < nums.length; right += 1) {
            total += nums[right];
            // While the window is big enough, record it and try a shorter one.
            while (total >= target) {
                best = Math.min(best, right - left + 1);
                total -= nums[left];
                left += 1;
            }
        }
        return best > nums.length ? 0 : best;
    }
}
