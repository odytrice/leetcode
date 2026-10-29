public class ReferenceSolution : Solution
{
    // O(n) time and space. Look for the partner before storing the current value.
    public override int[] TwoSum(int[] nums, int target)
    {
        // seen maps each value already visited to its index.
        var seen = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i += 1)
        {
            if (seen.TryGetValue(target - nums[i], out int j))
            {
                return [j, i];
            }
            // Storing after the check stops a value from pairing with itself.
            seen[nums[i]] = i;
        }
        // The problem guarantees one answer, so this line is never reached.
        throw new ArgumentException("No answer");
    }
}
