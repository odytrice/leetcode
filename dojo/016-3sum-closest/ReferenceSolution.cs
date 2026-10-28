public class ReferenceSolution : Solution
{
    public override int ThreeSumClosest(int[] nums, int target)
    {
        Array.Sort(nums);
        int best = nums[0] + nums[1] + nums[2];
        for (int i = 0; i < nums.Length - 2; i++)
        {
            int l = i + 1, r = nums.Length - 1;
            while (l < r)
            {
                int sum = nums[i] + nums[l] + nums[r];
                if (Math.Abs(sum - target) < Math.Abs(best - target)) best = sum;
                if (sum == target) return sum;
                if (sum < target) l++; else r--;
            }
        }
        return best;
    }
}
