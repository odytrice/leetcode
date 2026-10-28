/** O(n) time, O(1) space. Each house either skips or adds to the total two back. */
class ReferenceSolution extends Solution {
    @Override
    public int rob(int[] nums) {
        int previous = 0;
        int best = 0;
        for (int value : nums) {
            int next = Math.max(best, previous + value);
            previous = best;
            best = next;
        }
        return best;
    }
}
