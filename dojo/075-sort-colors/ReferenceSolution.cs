public class ReferenceSolution : Solution
{
    public override void SortColors(int[] nums)
    {
        int low = 0, i = 0, high = nums.Length - 1;
        while (i <= high)
        {
            if (nums[i] == 0) { (nums[low], nums[i]) = (nums[i], nums[low]); low++; i++; }
            else if (nums[i] == 2) { (nums[high], nums[i]) = (nums[i], nums[high]); high--; }
            else i++;
        }
    }
}
