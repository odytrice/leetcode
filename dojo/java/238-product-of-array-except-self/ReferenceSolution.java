/** O(n) time, O(1) extra space. Writes prefixes, then multiplies suffixes. */
class ReferenceSolution extends Solution {
    @Override
    public int[] productExceptSelf(int[] nums) {
        int[] result = new int[nums.length];
        int prefix = 1;
        int suffix = 1;
        // Pass 1: result[i] becomes the product of everything left of i.
        for (int index = 0; index < nums.length; index += 1) {
            result[index] = prefix;
            prefix *= nums[index];
        }
        // Pass 2: multiply in the product of everything right of i.
        for (int index = nums.length - 1; index >= 0; index -= 1) {
            result[index] *= suffix;
            suffix *= nums[index];
        }
        return result;
    }
}
