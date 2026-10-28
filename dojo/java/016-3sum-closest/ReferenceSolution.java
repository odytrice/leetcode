import java.util.Arrays;

/** O(n^2) time. Sorts, then shrinks the gap with two pointers. */
class ReferenceSolution extends Solution {
    @Override
    public int threeSumClosest(int[] nums, int target) {
        Arrays.sort(nums);
        int best = nums[0] + nums[1] + nums[2];
        for (int first = 0; first < nums.length - 2; first++) {
            int left = first + 1;
            int right = nums.length - 1;
            while (left < right) {
                int total = nums[first] + nums[left] + nums[right];
                if (Math.abs(total - target) < Math.abs(best - target)) {
                    best = total;
                }
                if (total == target) {
                    return total;
                }
                if (total < target) {
                    left++;
                } else {
                    right--;
                }
            }
        }
        return best;
    }
}
