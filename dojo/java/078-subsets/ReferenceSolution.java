import java.util.ArrayList;
import java.util.List;

/** O(n * 2^n) time. Each value doubles the result set by extending every subset. */
class ReferenceSolution extends Solution {
    @Override
    public List<List<Integer>> subsets(int[] nums) {
        // The empty set is a subset of everything and seeds the doubling.
        List<List<Integer>> result = new ArrayList<>();
        result.add(new ArrayList<>());
        for (int value : nums) {
            // Freeze the size so the subsets added in this pass are not extended again.
            int count = result.size();
            for (int index = 0; index < count; index += 1) {
                List<Integer> extended = new ArrayList<>(result.get(index));
                extended.add(value);
                result.add(extended);
            }
        }
        return result;
    }
}
