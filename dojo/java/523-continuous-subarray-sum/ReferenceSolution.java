import java.util.HashMap;
import java.util.Map;

/** O(n) time. A repeated remainder means a subarray divisible by k. */
class ReferenceSolution extends Solution {
    @Override
    public boolean checkSubarraySum(int[] nums, int k) {
        // first maps each prefix-sum remainder to the earliest index where it appeared.
        Map<Integer, Integer> first = new HashMap<>();
        // The empty prefix has remainder 0 and sits just before index 0.
        first.put(0, -1);
        int total = 0;
        for (int index = 0; index < nums.length; index += 1) {
            total += nums[index];
            int remainder = total % k;
            Integer start = first.get(remainder);
            // Only store the first index, so later matches give the longest subarray.
            if (start == null) {
                first.put(remainder, index);
            } else if (index - start >= 2) {
                // Same remainder twice: the sum between them is a multiple of k, and it has 2+ elements.
                return true;
            }
        }
        return false;
    }
}
