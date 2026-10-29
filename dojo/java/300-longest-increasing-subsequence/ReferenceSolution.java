import java.util.ArrayList;
import java.util.List;

/** O(n log n) time. tails[k] is the smallest tail of an increasing run of length k + 1. */
class ReferenceSolution extends Solution {
    @Override
    public int lengthOfLIS(int[] nums) {
        // tails stays sorted, which is what makes the binary search valid.
        List<Integer> tails = new ArrayList<>();
        for (int value : nums) {
            // Find the first tail that is not smaller than value.
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
            // Bigger than every tail: value extends the longest run by one.
            if (low == tails.size()) {
                tails.add(value);
            } else {
                // A smaller tail for that length leaves more room for later values.
                tails.set(low, value);
            }
        }
        return tails.size();
    }
}
