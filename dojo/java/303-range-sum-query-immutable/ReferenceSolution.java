/** O(n) build, O(1) queries. Stores prefix sums so a range is one subtraction. */
class ReferenceSolution extends NumArray {
    // prefix[i] is the sum of the first i values, so prefix[0] is 0.
    private final int[] prefix;

    ReferenceSolution(int[] nums) {
        super(nums);
        prefix = new int[nums.length + 1];
        for (int index = 0; index < nums.length; index += 1) {
            prefix[index + 1] = prefix[index] + nums[index];
        }
    }

    @Override
    public int sumRange(int left, int right) {
        // Everything up to right, minus everything before left.
        return prefix[right + 1] - prefix[left];
    }
}
