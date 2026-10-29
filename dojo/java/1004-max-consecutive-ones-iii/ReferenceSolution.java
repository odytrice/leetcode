/** O(n) time. The window may hold at most k zeros. */
class ReferenceSolution extends Solution {
    @Override
    public int longestOnes(int[] nums, int k) {
        int left = 0;
        int zeros = 0;
        int best = 0;
        for (int right = 0; right < nums.length; right += 1) {
            if (nums[right] == 0) {
                zeros += 1;
            }
            while (zeros > k) {
                if (nums[left] == 0) {
                    zeros -= 1;
                }
                left += 1;
            }
            best = Math.max(best, right - left + 1);
        }
        return best;
    }
}
