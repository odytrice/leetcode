public class ReferenceSolution : Solution
{
    public override int LongestOnes(int[] nums, int k)
    {
        int left = 0, zeros = 0, best = 0;
        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 0) zeros++;
            while (zeros > k) if (nums[left++] == 0) zeros--;
            best = Math.Max(best, right - left + 1);
        }
        return best;
    }
}
