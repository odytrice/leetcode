public class ReferenceSolution : Solution
{
    public override IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<IList<int>>();
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            int l = i + 1, r = nums.Length - 1;
            while (l < r)
            {
                int sum = nums[i] + nums[l] + nums[r];
                if (sum < 0) l++;
                else if (sum > 0) r--;
                else
                {
                    result.Add(new[] { nums[i], nums[l], nums[r] });
                    int left = nums[l], right = nums[r];
                    while (l < r && nums[l] == left) l++;
                    while (l < r && nums[r] == right) r--;
                }
            }
        }
        return result;
    }
}
