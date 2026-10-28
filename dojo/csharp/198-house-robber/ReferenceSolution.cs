public class ReferenceSolution : Solution
{
    public override int Rob(int[] nums)
    {
        int previous = 0, best = 0;
        foreach (int n in nums) { int next = Math.Max(best, previous + n); previous = best; best = next; }
        return best;
    }
}
