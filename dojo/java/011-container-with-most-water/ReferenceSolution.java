/** O(n) time, O(1) space. Moves the shorter wall inward; it can only improve. */
class ReferenceSolution extends Solution {
    @Override
    public int maxArea(int[] height) {
        int left = 0;
        int right = height.length - 1;
        int best = 0;
        while (left < right) {
            best = Math.max(best, (right - left) * Math.min(height[left], height[right]));
            if (height[left] <= height[right]) {
                left += 1;
            } else {
                right -= 1;
            }
        }
        return best;
    }
}
