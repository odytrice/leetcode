public class ReferenceSolution : Solution
{
    // O(n) time, O(1) space. Moving the shorter wall inward is the only move that can help.
    public override int MaxArea(int[] height)
    {
        int l = 0;
        int r = height.Length - 1;
        int best = 0;
        while (l < r)
        {
            best = Math.Max(best, (r - l) * Math.Min(height[l], height[r]));
            if (height[l] <= height[r])
            {
                l += 1;
            }
            else
            {
                r -= 1;
            }
        }
        return best;
    }
}
