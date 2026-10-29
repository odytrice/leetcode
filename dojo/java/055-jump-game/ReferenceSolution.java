/** O(n) time. Tracks the furthest reachable index. */
class ReferenceSolution extends Solution {
    @Override
    public boolean canJump(int[] nums) {
        // reach is the furthest index any jump from the earlier cells can land on.
        int reach = 0;
        for (int index = 0; index < nums.length; index += 1) {
            // This cell lies beyond every jump so far, so we are stuck before it.
            if (index > reach) {
                return false;
            }
            reach = Math.max(reach, index + nums[index]);
            // Stop as soon as the last index is in range.
            if (reach >= nums.length - 1) {
                return true;
            }
        }
        return true;
    }
}
