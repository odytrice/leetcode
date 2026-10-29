public class ReferenceSolution : Solution
{
    // O(n * 2^n) time. Each value doubles the result by extending every existing subset.
    public override IList<IList<int>> Subsets(int[] nums)
    {
        var result = new List<IList<int>> { new List<int>() };
        foreach (int n in nums)
        {
            int count = result.Count;
            for (int i = 0; i < count; i += 1)
            {
                var subset = new List<int>(result[i]) { n };
                result.Add(subset);
            }
        }
        return result;
    }
}
