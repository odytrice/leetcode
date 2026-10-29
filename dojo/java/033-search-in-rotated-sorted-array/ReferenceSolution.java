/** O(log n) time. Decides which half is sorted, then whether the target is in it. */
class ReferenceSolution extends Solution {
    @Override
    public int search(int[] nums, int target) {
        int left = 0;
        int right = nums.length - 1;
        while (left <= right) {
            int middle = (left + right) / 2;
            if (nums[middle] == target) {
                return middle;
            }
            // At least one half is always in order; only that half supports a simple range check.
            // The else-if branch below handles the case where the right half is the sorted one.
            if (nums[left] <= nums[middle]) {
                // The left half is sorted: keep it only if the target falls inside its range.
                if (nums[left] <= target && target < nums[middle]) {
                    right = middle - 1;
                } else {
                    left = middle + 1;
                }
            } else if (nums[middle] < target && target <= nums[right]) {
                left = middle + 1;
            } else {
                right = middle - 1;
            }
        }
        // -1 means the target is not in the array.
        return -1;
    }
}
