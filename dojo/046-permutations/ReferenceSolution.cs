public class ReferenceSolution : Solution
{
    public override IList<IList<int>> Permute(int[] nums)
    {
        var result = new List<IList<int>>(); var path = new List<int>(); var used = new bool[nums.Length];
        void Search()
        {
            if (path.Count == nums.Length) { result.Add(path.ToArray()); return; }
            for (int i = 0; i < nums.Length; i++)
            {
                if (used[i]) continue;
                used[i] = true; path.Add(nums[i]); Search(); path.RemoveAt(path.Count - 1); used[i] = false;
            }
        }
        Search(); return result;
    }
}
