/** O(log n) time. The minimum is where the order breaks. */
class ReferenceSolution extends Solution {
    @Override
    public int findMin(int[] nums) {
        // The minimum always stays inside nums[left..right].
        int left = 0;
        int right = nums.length - 1;
        while (left < right) {
            int middle = (left + right) / 2;
            // middle is above the right end, so the drop (and the minimum) lies to its right.
            if (nums[middle] > nums[right]) {
                left = middle + 1;
            } else {
                // middle..right is sorted, so middle itself may be the minimum; keep it.
                right = middle;
            }
        }
        return nums[left];
    }
}
