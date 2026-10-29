import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

/** O(n^(target/min)) time. Reuses the current value by searching from the same index. */
class ReferenceSolution extends Solution {
    @Override
    public List<List<Integer>> combinationSum(int[] candidates, int target) {
        // Sort a copy so the loop can stop at the first value that is too big.
        int[] values = candidates.clone();
        Arrays.sort(values);
        List<List<Integer>> result = new ArrayList<>();
        search(values, 0, target, new ArrayList<>(), result);
        return result;
    }

    private void search(int[] values, int start, int remaining, List<Integer> path, List<List<Integer>> result) {
        // The path sums exactly to the target, so record a copy of it.
        if (remaining == 0) {
            result.add(new ArrayList<>(path));
            return;
        }
        // Only pick from start onward so each combination is built in one order.
        for (int index = start; index < values.length; index += 1) {
            // Values are sorted, so every later value is too big as well.
            if (values[index] > remaining) {
                break;
            }
            path.add(values[index]);
            // Recurse from the same index because a value may be used again.
            search(values, index, remaining - values[index], path, result);
            path.remove(path.size() - 1);
        }
    }
}
