public class ReferenceSolution : Solution
{
    public override IList<IList<int>> Subsets(int[] nums)
    {
        var result = new List<IList<int>> { new List<int>() };
        foreach (int n in nums)
        {
            int count = result.Count;
            for (int i = 0; i < count; i++) { var subset = new List<int>(result[i]) { n }; result.Add(subset); }
        }
        return result;
    }
}
