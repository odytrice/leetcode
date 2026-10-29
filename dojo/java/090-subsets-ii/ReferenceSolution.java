import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

/** O(n * 2^n) time. Sorts, then skips duplicates at the same depth. */
class ReferenceSolution extends Solution {
    @Override
    public List<List<Integer>> subsetsWithDup(int[] nums) {
        int[] values = nums.clone();
        Arrays.sort(values);
        List<List<Integer>> result = new ArrayList<>();
        search(values, 0, new ArrayList<>(), result);
        return result;
    }

    private void search(int[] values, int start, List<Integer> path, List<List<Integer>> result) {
        result.add(new ArrayList<>(path));
        for (int index = start; index < values.length; index += 1) {
            if (index > start && values[index] == values[index - 1]) {
                continue;
            }
            path.add(values[index]);
            search(values, index + 1, path, result);
            path.remove(path.size() - 1);
        }
    }
}
