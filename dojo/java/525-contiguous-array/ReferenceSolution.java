import java.util.HashMap;
import java.util.Map;

/** O(n) time. Equal zeros and ones means a repeated running balance. */
class ReferenceSolution extends Solution {
    @Override
    public int findMaxLength(int[] nums) {
        Map<Integer, Integer> first = new HashMap<>();
        first.put(0, -1);
        int balance = 0;
        int best = 0;
        for (int index = 0; index < nums.length; index++) {
            balance += nums[index] == 1 ? 1 : -1;
            Integer start = first.get(balance);
            if (start == null) {
                first.put(balance, index);
            } else {
                best = Math.max(best, index - start);
            }
        }
        return best;
    }
}
