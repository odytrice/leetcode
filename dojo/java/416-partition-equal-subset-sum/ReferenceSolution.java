/** O(n * sum) time, O(sum) space. Descending totals prevent reusing one number. */
class ReferenceSolution extends Solution {
    @Override
    public boolean canPartition(int[] nums) {
        int total = 0;
        for (int value : nums) {
            total += value;
        }
        if (total % 2 != 0) {
            return false;
        }
        int target = total / 2;
        boolean[] reachable = new boolean[target + 1];
        reachable[0] = true;
        for (int value : nums) {
            for (int subtotal = target; subtotal >= value; subtotal--) {
                if (reachable[subtotal - value]) {
                    reachable[subtotal] = true;
                }
            }
        }
        return reachable[target];
    }
}
