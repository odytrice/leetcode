public class ReferenceSolution : Solution
{
    // O(n^2) time. Sort, fix one value, then close in with two pointers.
    public override IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<IList<int>>();
        for (int i = 0; i < nums.Length - 2; i += 1)
        {
            // Skip a repeated first value; it would produce the same triples.
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            int l = i + 1;
            int r = nums.Length - 1;
            while (l < r)
            {
                int sum = nums[i] + nums[l] + nums[r];
                if (sum < 0)
                {
                    l += 1;
                }
                else if (sum > 0)
                {
                    r -= 1;
                }
                else
                {
                    result.Add(new[] { nums[i], nums[l], nums[r] });
                    int left = nums[l];
                    int right = nums[r];
                    // Step past duplicates on both sides before searching again.
                    while (l < r && nums[l] == left)
                    {
                        l += 1;
                    }
                    while (l < r && nums[r] == right)
                    {
                        r -= 1;
                    }
                }
            }
        }
        return result;
    }
}
