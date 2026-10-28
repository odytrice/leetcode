/** O(n) time, O(1) space. Moves the wider end inward while the sum is wrong. */
class ReferenceSolution extends Solution {
    @Override
    public int[] twoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.length - 1;
        while (left < right) {
            int total = numbers[left] + numbers[right];
            if (total == target) {
                return new int[] {left + 1, right + 1};
            }
            if (total < target) {
                left++;
            } else {
                right--;
            }
        }
        throw new IllegalArgumentException("No answer");
    }
}
