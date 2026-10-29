public class ReferenceSolution : Solution
{
    // O(n) time, O(1) space. Dutch national flag: grow the 0 and 2 regions inward.
    public override void SortColors(int[] nums)
    {
        int low = 0;
        int i = 0;
        int high = nums.Length - 1;
        while (i <= high)
        {
            if (nums[i] == 0)
            {
                (nums[low], nums[i]) = (nums[i], nums[low]);
                low += 1;
                i += 1;
            }
            else if (nums[i] == 2)
            {
                // The swapped-in value is unchecked, so i stays put.
                (nums[high], nums[i]) = (nums[i], nums[high]);
                high -= 1;
            }
            else
            {
                i += 1;
            }
        }
    }
}
