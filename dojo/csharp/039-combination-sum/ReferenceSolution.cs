public class ReferenceSolution : Solution
{
    // Backtracking over sorted candidates. Searching from the same index allows reuse.
    public override IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        var values = candidates.Order().ToArray();
        var path = new List<int>();
        var result = new List<IList<int>>();

        void Search(int start, int remaining)
        {
            if (remaining == 0)
            {
                result.Add(path.ToArray());
                return;
            }
            // Sorted values let the loop stop once a candidate overshoots.
            for (int i = start; i < values.Length && values[i] <= remaining; i += 1)
            {
                path.Add(values[i]);
                Search(i, remaining - values[i]);
                path.RemoveAt(path.Count - 1);
            }
        }

        Search(0, target);
        return result;
    }
}
