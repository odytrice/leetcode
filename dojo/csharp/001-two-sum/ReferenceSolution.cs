public class ReferenceSolution : Solution
{
    // O(n) time and space. Look for the partner before storing the current value.
    public override int[] TwoSum(int[] nums, int target)
    {
        var seen = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i += 1)
        {
            if (seen.TryGetValue(target - nums[i], out int j))
            {
                return [j, i];
            }
            seen[nums[i]] = i;
        }
        throw new ArgumentException("No answer");
    }
}
