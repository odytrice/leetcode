/** O(n) time, O(1) space. Each house either skips or adds to the total two back. */
class ReferenceSolution extends Solution {
    @Override
    public int rob(int[] nums) {
        // best is the most loot up to the previous house; previous is the most up to the one before.
        int previous = 0;
        int best = 0;
        for (int value : nums) {
            // Either skip this house, or rob it on top of the total from two houses back.
            int next = Math.max(best, previous + value);
            previous = best;
            best = next;
        }
        return best;
    }
}
