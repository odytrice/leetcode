public class Solution
{
    public int SubarraySum(int[] nums, int k)
    {
        int result = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i; j < nums.Length; j++)
            {
                var sum = nums[i .. (j + 1)].Sum();
                if(sum == k) result++;
            }
        }
        return result;
    }
}
