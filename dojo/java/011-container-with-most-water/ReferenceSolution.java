/** O(n) time, O(1) space. Moves the shorter wall inward; it can only improve. */
class ReferenceSolution extends Solution {
    @Override
    public int maxArea(int[] height) {
        // Start with the widest container and narrow it one wall at a time.
        int left = 0;
        int right = height.length - 1;
        int best = 0;
        while (left < right) {
            // The water level is capped by the shorter of the two walls.
            best = Math.max(best, (right - left) * Math.min(height[left], height[right]));
            // Moving the taller wall can never help, since the shorter wall still limits the height.
            if (height[left] <= height[right]) {
                left += 1;
            } else {
                right -= 1;
            }
        }
        return best;
    }
}
