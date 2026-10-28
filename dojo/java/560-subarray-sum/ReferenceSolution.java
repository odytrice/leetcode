import java.util.HashMap;
import java.util.Map;

/** O(n) time and space. Counts earlier prefixes whose difference is k. */
class ReferenceSolution extends Solution {
    @Override
    public int subarraySum(int[] nums, int k) {
        Map<Integer, Integer> counts = new HashMap<>();
        counts.put(0, 1);
        int total = 0;
        int answer = 0;
        for (int value : nums) {
            total += value;
            answer += counts.getOrDefault(total - k, 0);
            counts.merge(total, 1, Integer::sum);
        }
        return answer;
    }
}
