public class ReferenceSolution : Solution
{
    // O(n * 2^n) time. Each value doubles the result by extending every existing subset.
    public override IList<IList<int>> Subsets(int[] nums)
    {
        // Start with the empty subset.
        var result = new List<IList<int>> { new List<int>() };
        foreach (int n in nums)
        {
            // Snapshot the count so subsets added in this round are not extended again.
            int count = result.Count;
            for (int i = 0; i < count; i += 1)
            {
                // Copy the old subset and append n, keeping the original as well.
                var subset = new List<int>(result[i]) { n };
                result.Add(subset);
            }
        }
        return result;
    }
}
