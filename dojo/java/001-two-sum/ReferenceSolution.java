import java.util.HashMap;
import java.util.Map;

/** O(n) time and space. Remembers each value's index before it is needed. */
class ReferenceSolution extends Solution {
    @Override
    public int[] twoSum(int[] nums, int target) {
        // seen maps each value already passed to the index where it appeared.
        Map<Integer, Integer> seen = new HashMap<>();
        for (int index = 0; index < nums.length; index += 1) {
            // Look for the partner before storing, so a value never pairs with itself.
            Integer partner = seen.get(target - nums[index]);
            if (partner != null) {
                return new int[] {partner, index};
            }
            seen.put(nums[index], index);
        }
        throw new IllegalArgumentException("No answer");
    }
}
