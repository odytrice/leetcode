import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

/** O(n^(target/min)) time. Reuses the current value by searching from the same index. */
class ReferenceSolution extends Solution {
    @Override
    public List<List<Integer>> combinationSum(int[] candidates, int target) {
        int[] values = candidates.clone();
        Arrays.sort(values);
        List<List<Integer>> result = new ArrayList<>();
        search(values, 0, target, new ArrayList<>(), result);
        return result;
    }

    private void search(int[] values, int start, int remaining, List<Integer> path, List<List<Integer>> result) {
        if (remaining == 0) {
            result.add(new ArrayList<>(path));
            return;
        }
        for (int index = start; index < values.length; index += 1) {
            if (values[index] > remaining) {
                break;
            }
            path.add(values[index]);
            search(values, index, remaining - values[index], path, result);
            path.remove(path.size() - 1);
        }
    }
}
