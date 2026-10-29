/** O(n * sum) time, O(sum) space. Descending totals prevent reusing one number. */
class ReferenceSolution extends Solution {
    @Override
    public boolean canPartition(int[] nums) {
        int total = 0;
        for (int value : nums) {
            total += value;
        }
        // An odd total cannot be split into two equal integer halves.
        if (total % 2 != 0) {
            return false;
        }
        // The task reduces to finding a subset that sums to half the total.
        int target = total / 2;
        // reachable[s] is true when some subset of the numbers seen so far sums to s.
        boolean[] reachable = new boolean[target + 1];
        reachable[0] = true;
        for (int value : nums) {
            // Go downward so reachable[subtotal - value] still reflects the state before this value.
            for (int subtotal = target; subtotal >= value; subtotal -= 1) {
                if (reachable[subtotal - value]) {
                    reachable[subtotal] = true;
                }
            }
        }
        return reachable[target];
    }
}
