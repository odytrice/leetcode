/** O(n) time, O(1) space. Shrinks the window while it still reaches the target. */
class ReferenceSolution extends Solution {
    @Override
    public int minSubArrayLen(int target, int[] nums) {
        int left = 0;
        int total = 0;
        int best = nums.length + 1;
        for (int right = 0; right < nums.length; right++) {
            total += nums[right];
            while (total >= target) {
                best = Math.min(best, right - left + 1);
                total -= nums[left];
                left++;
            }
        }
        return best > nums.length ? 0 : best;
    }
}
