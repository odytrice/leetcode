public class ReferenceSolution : RandomizedSet
{
    // O(1) per operation. A list for random picks, plus each value's index in it.
    private readonly List<int> values = [];
    private readonly Dictionary<int, int> index = new();

    public override bool Insert(int val)
    {
        if (index.ContainsKey(val))
        {
            return false;
        }
        // Append at the end and remember its position.
        index[val] = values.Count;
        values.Add(val);
        return true;
    }

    public override bool Remove(int val)
    {
        if (!index.TryGetValue(val, out int i))
        {
            return false;
        }
        // Move the last value into the gap so removal from the list is O(1).
        int last = values[^1];
        values[i] = last;
        index[last] = i;
        // The last slot is now a duplicate, so drop it.
        values.RemoveAt(values.Count - 1);
        index.Remove(val);
        return true;
    }

    public override int GetRandom()
    {
        // Every value has one slot in the list, so a random index is uniform.
        return values[Random.Shared.Next(values.Count)];
    }
}
