public class ReferenceSolution : Solution
{
    public override int[] TwoSum(int[] nums, int target)
    {
        var seen = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (seen.TryGetValue(target - nums[i], out int j)) return [j, i];
            seen[nums[i]] = i;
        }
        throw new ArgumentException("No answer");
    }
}
