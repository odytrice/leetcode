import java.util.HashSet;
import java.util.Set;

/** O(n) time. Only starts counting at values with no predecessor. */
class ReferenceSolution extends Solution {
    @Override
    public int longestConsecutive(int[] nums) {
        Set<Integer> values = new HashSet<>();
        for (int value : nums) {
            values.add(value);
        }
        int best = 0;
        for (int value : values) {
            if (values.contains(value - 1)) {
                continue;
            }
            int length = 1;
            while (values.contains(value + length)) {
                length += 1;
            }
            best = Math.max(best, length);
        }
        return best;
    }
}
