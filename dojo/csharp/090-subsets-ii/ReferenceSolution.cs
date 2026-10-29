public class ReferenceSolution : Solution
{
    // O(n * 2^n) time. Sort, then skip a repeated value at the same depth.
    public override IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<IList<int>>();
        var path = new List<int>();

        void Search(int start)
        {
            // Every node of the search tree is a valid subset, not just the leaves.
            result.Add(path.ToArray());
            for (int i = start; i < nums.Length; i += 1)
            {
                // The same value at the same depth would rebuild subsets we already have.
                if (i > start && nums[i] == nums[i - 1])
                {
                    continue;
                }
                path.Add(nums[i]);
                // Later choices only look to the right, so each subset is built exactly once.
                Search(i + 1);
                path.RemoveAt(path.Count - 1);
            }
        }

        Search(0);
        return result;
    }
}
