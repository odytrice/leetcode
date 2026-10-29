/** O(n) time, O(1) space. Dutch national flag: grows the 0 and 2 regions inward. */
class ReferenceSolution extends Solution {
    @Override
    public void sortColors(int[] nums) {
        int low = 0;
        int index = 0;
        int high = nums.length - 1;
        while (index <= high) {
            if (nums[index] == 0) {
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
