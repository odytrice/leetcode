import java.util.HashMap;
import java.util.Map;

/** O(n) time. A repeated remainder means a subarray divisible by k. */
class ReferenceSolution extends Solution {
    @Override
    public boolean checkSubarraySum(int[] nums, int k) {
        Map<Integer, Integer> first = new HashMap<>();
        first.put(0, -1);
        int total = 0;
        for (int index = 0; index < nums.length; index++) {
            total += nums[index];
            int remainder = total % k;
            Integer start = first.get(remainder);
            if (start == null) {
                first.put(remainder, index);
            } else if (index - start >= 2) {
                return true;
            }
        }
        return false;
    }
}
