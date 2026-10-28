public class ReferenceSolution : Solution
{
    public override IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        Array.Sort(nums); var result = new List<IList<int>>(); var path = new List<int>();
        void Search(int start)
        {
            result.Add(path.ToArray());
            for (int i = start; i < nums.Length; i++)
            {
                if (i > start && nums[i] == nums[i - 1]) continue;
                path.Add(nums[i]); Search(i + 1); path.RemoveAt(path.Count - 1);
            }
        }
        Search(0); return result;
    }
}
