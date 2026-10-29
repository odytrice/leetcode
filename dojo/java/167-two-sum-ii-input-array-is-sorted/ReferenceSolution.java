/** O(n) time, O(1) space. Moves the wider end inward while the sum is wrong. */
class ReferenceSolution extends Solution {
    @Override
    public int[] twoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.length - 1;
        while (left < right) {
            int total = numbers[left] + numbers[right];
            // The problem uses 1-based indexes.
            if (total == target) {
                return new int[] {left + 1, right + 1};
            }
            // Too small: only a larger left value can help. Too big: only a smaller right value.
            if (total < target) {
                left += 1;
            } else {
                right -= 1;
            }
        }
        throw new IllegalArgumentException("No answer");
    }
}
