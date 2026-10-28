/** O(log n) time. Two lower-bound searches: one for the target, one past it. */
class ReferenceSolution extends Solution {
    @Override
    public int[] searchRange(int[] nums, int target) {
        int first = bound(nums, target, false);
        if (first == nums.length || nums[first] != target) {
            return new int[] {-1, -1};
        }
        return new int[] {first, bound(nums, target, true) - 1};
    }

    private int bound(int[] nums, int target, boolean upper) {
        int left = 0;
        int right = nums.length;
        while (left < right) {
            int middle = (left + right) / 2;
            if (nums[middle] < target || (upper && nums[middle] == target)) {
                left = middle + 1;
            } else {
                right = middle;
            }
        }
        return left;
    }
}
