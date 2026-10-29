import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/** O(n) time. Buckets values by frequency, then reads from the top. */
class ReferenceSolution extends Solution {
    @Override
    public List<Integer> topKFrequent(int[] nums, int k) {
        // counts maps each value to how many times it appears.
        Map<Integer, Integer> counts = new HashMap<>();
        for (int value : nums) {
            counts.merge(value, 1, Integer::sum);
        }
        // buckets[c] lists the values that appear exactly c times; c is at most nums.length.
        List<List<Integer>> buckets = new ArrayList<>();
        for (int index = 0; index <= nums.length; index += 1) {
            buckets.add(new ArrayList<>());
        }
        for (Map.Entry<Integer, Integer> entry : counts.entrySet()) {
            buckets.get(entry.getValue()).add(entry.getKey());
        }
        // Read buckets from the highest count down until k values are collected.
        List<Integer> result = new ArrayList<>();
        for (int count = nums.length; count > 0 && result.size() < k; count -= 1) {
            for (int value : buckets.get(count)) {
                result.add(value);
                if (result.size() == k) {
                    break;
                }
            }
        }
        return result;
    }
}
