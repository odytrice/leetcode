import java.util.HashMap;
import java.util.Map;

/** O(n) time and space. Counts earlier prefixes whose difference is k. */
class ReferenceSolution extends Solution {
    @Override
    public int subarraySum(int[] nums, int k) {
        // counts maps each prefix sum to how many times it has appeared so far.
        Map<Integer, Integer> counts = new HashMap<>();
        // The empty prefix (sum 0) lets subarrays that start at index 0 be counted.
        counts.put(0, 1);
        int total = 0;
        int answer = 0;
        for (int value : nums) {
            total += value;
            // Every earlier prefix equal to total - k starts a subarray ending here that sums to k.
            answer += counts.getOrDefault(total - k, 0);
            // Record this prefix after counting, so a subarray is never empty.
            counts.merge(total, 1, Integer::sum);
        }
        return answer;
    }
}
