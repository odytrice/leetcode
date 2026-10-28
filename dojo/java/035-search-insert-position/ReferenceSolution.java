/** O(log n) time. Finds the first index whose value is not below the target. */
class ReferenceSolution extends Solution {
    @Override
    public int searchInsert(int[] nums, int target) {
        int left = 0;
        int right = nums.length;
        while (left < right) {
            int middle = (left + right) / 2;
            if (nums[middle] < target) {
                left = middle + 1;
            } else {
                right = middle;
            }
        }
        return left;
    }
}
