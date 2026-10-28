public class ReferenceSolution : Solution
{
    public override int FindMaxLength(int[] nums)
    {
        var first = new Dictionary<int, int> { [0] = -1 };
        int balance = 0, best = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            balance += nums[i] == 0 ? -1 : 1;
            if (first.TryGetValue(balance, out int start)) best = Math.Max(best, i - start);
            else first[balance] = i;
        }
        return best;
    }
}
