import java.util.HashSet;
import java.util.Set;

/** O(n) time. Only starts counting at values with no predecessor. */
class ReferenceSolution extends Solution {
    @Override
    public int longestConsecutive(int[] nums) {
        // A set gives O(1) lookups and drops duplicate values.
        Set<Integer> values = new HashSet<>();
        for (int value : nums) {
            values.add(value);
        }
        int best = 0;
        for (int value : values) {
            // value - 1 exists, so this run is counted from its real start instead.
            if (values.contains(value - 1)) {
                continue;
            }
            // Count upward; each value is walked over by only one run, keeping this O(n) overall.
            int length = 1;
            while (values.contains(value + length)) {
                length += 1;
            }
            best = Math.max(best, length);
        }
        return best;
    }
}
