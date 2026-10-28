public class ReferenceSolution : RandomizedSet
{
    private readonly List<int> values = [];
    private readonly Dictionary<int, int> index = new();
    public override bool Insert(int val)
    {
        if (index.ContainsKey(val)) return false;
        index[val] = values.Count; values.Add(val); return true;
    }
    public override bool Remove(int val)
    {
        if (!index.TryGetValue(val, out int i)) return false;
        int last = values[^1]; values[i] = last; index[last] = i;
        values.RemoveAt(values.Count - 1); index.Remove(val); return true;
    }
    public override int GetRandom() => values[Random.Shared.Next(values.Count)];
}
