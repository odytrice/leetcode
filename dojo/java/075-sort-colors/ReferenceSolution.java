/** O(n) time, O(1) space. Dutch national flag: grows the 0 and 2 regions inward. */
class ReferenceSolution extends Solution {
    @Override
    public void sortColors(int[] nums) {
        // Invariant: [0, low) is all 0s, [low, index) is all 1s, (high, end] is all 2s.
        int low = 0;
        int index = 0;
        int high = nums.length - 1;
        // Cells between index and high are still unsorted.
        while (index <= high) {
            if (nums[index] == 0) {
                // The value swapped in from low is a 1 already checked, so both pointers advance.
                int swap = nums[low];
                nums[low] = nums[index];
                nums[index] = swap;
                low += 1;
                index += 1;
            } else if (nums[index] == 2) {
                int swap = nums[high];
                nums[high] = nums[index];
                nums[index] = swap;
                // The swapped-in value is unchecked, so index stays put.
                high -= 1;
            } else {
                index += 1;
            }
        }
    }
}
