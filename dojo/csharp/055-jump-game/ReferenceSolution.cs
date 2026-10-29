public class ReferenceSolution : Solution
{
    // O(n) time. Track the furthest index reachable so far.
    public override bool CanJump(int[] nums)
    {
        int reach = 0;
        // i <= reach stops the scan at the first index we cannot get to.
        for (int i = 0; i < nums.Length && i <= reach; i += 1)
        {
            reach = Math.Max(reach, i + nums[i]);
            // Once the last index is in range, the answer is settled.
            if (reach >= nums.Length - 1)
            {
                return true;
            }
        }
        return false;
    }
}
