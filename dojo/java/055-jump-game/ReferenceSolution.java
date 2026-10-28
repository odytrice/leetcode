/** O(n) time. Tracks the furthest reachable index. */
class ReferenceSolution extends Solution {
    @Override
    public boolean canJump(int[] nums) {
        int reach = 0;
        for (int index = 0; index < nums.length; index++) {
            if (index > reach) {
                return false;
            }
            reach = Math.max(reach, index + nums[index]);
            if (reach >= nums.length - 1) {
                return true;
            }
        }
        return true;
    }
}
