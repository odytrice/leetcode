public class ReferenceSolution : Solution
{
    // O(n) time, O(1) space. Too small moves left up; too big moves right down.
    public override int[] TwoSum(int[] numbers, int target)
    {
        int l = 0;
        int r = numbers.Length - 1;
        while (l < r)
        {
            int sum = numbers[l] + numbers[r];
            if (sum == target)
            {
                // The problem uses 1-based indices.
                return [l + 1, r + 1];
            }
            // The array is sorted, so each pointer moves the sum in a known direction.
            if (sum < target)
            {
                l += 1;
            }
            else
            {
                r -= 1;
            }
        }
        throw new ArgumentException("No answer");
    }
}
