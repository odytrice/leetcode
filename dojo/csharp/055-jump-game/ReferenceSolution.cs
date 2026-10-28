public class ReferenceSolution : Solution
{
    public override bool CanJump(int[] nums)
    {
        int reach = 0;
        for (int i = 0; i < nums.Length && i <= reach; i++)
        { reach = Math.Max(reach, i + nums[i]); if (reach >= nums.Length - 1) return true; }
        return false;
    }
}
