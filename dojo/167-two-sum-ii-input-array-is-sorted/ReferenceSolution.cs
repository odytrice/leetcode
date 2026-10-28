public class ReferenceSolution : Solution
{
    public override int[] TwoSum(int[] numbers, int target)
    {
        int l = 0, r = numbers.Length - 1;
        while (l < r)
        {
            int sum = numbers[l] + numbers[r];
            if (sum == target) return [l + 1, r + 1];
            if (sum < target) l++; else r--;
        }
        throw new ArgumentException("No answer");
    }
}
