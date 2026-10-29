import java.util.ArrayList;
import java.util.List;

/** O(n * n!) time. Builds permutations by inserting each value at every position. */
class ReferenceSolution extends Solution {
    @Override
    public List<List<Integer>> permute(int[] nums) {
        // Start with one empty permutation so the first value has somewhere to go.
        List<List<Integer>> result = new ArrayList<>();
        result.add(new ArrayList<>());
        for (int value : nums) {
            // next holds every permutation of the values processed so far plus this one.
            List<List<Integer>> next = new ArrayList<>();
            for (List<Integer> permutation : result) {
                // A list of size k has k + 1 gaps where the new value can go.
                for (int position = 0; position <= permutation.size(); position += 1) {
                    List<Integer> copy = new ArrayList<>(permutation);
                    copy.add(position, value);
                    next.add(copy);
                }
            }
            result = next;
        }
        return result;
    }
}
