import java.util.ArrayList;
import java.util.List;

/** O(n * n!) time. Builds permutations by inserting each value at every position. */
class ReferenceSolution extends Solution {
    @Override
    public List<List<Integer>> permute(int[] nums) {
        List<List<Integer>> result = new ArrayList<>();
        result.add(new ArrayList<>());
        for (int value : nums) {
            List<List<Integer>> next = new ArrayList<>();
            for (List<Integer> permutation : result) {
                for (int position = 0; position <= permutation.size(); position++) {
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
