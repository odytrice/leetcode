import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

/** O(n^2) time. Sorts, then fixes one value and uses two pointers. */
class ReferenceSolution extends Solution {
    @Override
    public List<List<Integer>> threeSum(int[] nums) {
        // Sorting puts duplicates side by side and lets the pointers steer the sum.
        Arrays.sort(nums);
        List<List<Integer>> result = new ArrayList<>();
        for (int first = 0; first < nums.length - 2; first += 1) {
            // The same first value would only produce triplets already found.
            if (first > 0 && nums[first] == nums[first - 1]) {
                continue;
            }
            int left = first + 1;
            int right = nums.length - 1;
            while (left < right) {
                int total = nums[first] + nums[left] + nums[right];
                // Too small needs a bigger left value; too big needs a smaller right value.
                if (total < 0) {
                    left += 1;
                } else if (total > 0) {
                    right -= 1;
                } else {
                    result.add(List.of(nums[first], nums[left], nums[right]));
                    // Skip past every copy of both values so this triplet is not added again.
                    int leftValue = nums[left];
                    int rightValue = nums[right];
                    while (left < right && nums[left] == leftValue) {
                        left += 1;
                    }
                    while (left < right && nums[right] == rightValue) {
                        right -= 1;
                    }
                }
            }
        }
        return result;
    }
}
