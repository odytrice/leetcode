import java.util.ArrayList;
import java.util.List;

/** O(n log n) time. tails[k] is the smallest tail of an increasing run of length k + 1. */
class ReferenceSolution extends Solution {
    @Override
    public int lengthOfLIS(int[] nums) {
        List<Integer> tails = new ArrayList<>();
        for (int value : nums) {
            int low = 0;
            int high = tails.size();
            while (low < high) {
                int middle = (low + high) / 2;
                if (tails.get(middle) < value) {
                    low = middle + 1;
                } else {
                    high = middle;
                }
            }
            if (low == tails.size()) {
                tails.add(value);
            } else {
                tails.set(low, value);
            }
        }
        return tails.size();
    }
}
