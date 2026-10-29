public class ReferenceSolution : Solution
{
    // O(n) time. Track the furthest index reachable so far.
    public override bool CanJump(int[] nums)
    {
        int reach = 0;
        for (int i = 0; i < nums.Length && i <= reach; i += 1)
        {
            reach = Math.Max(reach, i + nums[i]);
            if (reach >= nums.Length - 1)
            {
                return true;
            }
        }
        return false;
    }
}
