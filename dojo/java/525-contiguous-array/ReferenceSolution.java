import java.util.HashMap;
import java.util.Map;

/** O(n) time. Equal zeros and ones means a repeated running balance. */
class ReferenceSolution extends Solution {
    @Override
    public int findMaxLength(int[] nums) {
        // first maps each balance to the earliest index where it was reached.
        Map<Integer, Integer> first = new HashMap<>();
        // Balance 0 before any element lets a subarray starting at index 0 be measured.
        first.put(0, -1);
        int balance = 0;
        int best = 0;
        for (int index = 0; index < nums.length; index += 1) {
            // Count a one as +1 and a zero as -1.
            balance += nums[index] == 1 ? 1 : -1;
            Integer start = first.get(balance);
            // Keep only the earliest index; a repeat means the stretch between them is balanced.
            if (start == null) {
                first.put(balance, index);
            } else {
                best = Math.max(best, index - start);
            }
        }
        return best;
    }
}
