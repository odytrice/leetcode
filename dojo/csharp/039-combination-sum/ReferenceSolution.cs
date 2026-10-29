public class ReferenceSolution : Solution
{
    // Backtracking over sorted candidates. Searching from the same index allows reuse.
    public override IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        var values = candidates.Order().ToArray();
        // path is the combination being built; remaining is what it still needs to reach target.
        var path = new List<int>();
        var result = new List<IList<int>>();

        void Search(int start, int remaining)
        {
            // The path sums exactly to the target.
            if (remaining == 0)
            {
                result.Add(path.ToArray());
                return;
            }
            // Sorted values let the loop stop once a candidate overshoots.
            for (int i = start; i < values.Length && values[i] <= remaining; i += 1)
            {
                path.Add(values[i]);
                // Passing i, not i + 1, lets the same value be chosen again.
                Search(i, remaining - values[i]);
                // Undo the choice before trying the next candidate.
                path.RemoveAt(path.Count - 1);
            }
        }

        Search(0, target);
        return result;
    }
}
