/** O(log n) time. Finds the first index whose value is not below the target. */
class ReferenceSolution extends Solution {
    @Override
    public int searchInsert(int[] nums, int target) {
        // right starts past the end because the target may belong after every value.
        int left = 0;
        int right = nums.length;
        while (left < right) {
            int middle = (left + right) / 2;
            // Values below the target can never be the answer, so drop them and middle too.
            if (nums[middle] < target) {
                left = middle + 1;
            } else {
                right = middle;
            }
        }
        return left;
    }
}
