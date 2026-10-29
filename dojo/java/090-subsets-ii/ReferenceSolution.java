import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

/** O(n * 2^n) time. Sorts, then skips duplicates at the same depth. */
class ReferenceSolution extends Solution {
    @Override
    public List<List<Integer>> subsetsWithDup(int[] nums) {
        // Sorting places equal values next to each other so duplicates are easy to spot.
        int[] values = nums.clone();
        Arrays.sort(values);
        List<List<Integer>> result = new ArrayList<>();
        search(values, 0, new ArrayList<>(), result);
        return result;
    }

    private void search(int[] values, int start, List<Integer> path, List<List<Integer>> result) {
        // Every path reached is a distinct subset, so record it on the way down.
        result.add(new ArrayList<>(path));
        for (int index = start; index < values.length; index += 1) {
            // Picking an equal value at the same depth would rebuild the same subsets.
            if (index > start && values[index] == values[index - 1]) {
                continue;
            }
            path.add(values[index]);
            search(values, index + 1, path, result);
            path.remove(path.size() - 1);
        }
    }
}
