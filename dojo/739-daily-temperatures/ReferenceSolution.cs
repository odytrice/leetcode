public class ReferenceSolution
{
    // O(n) time and space. Each index is pushed and popped at most once.
    public int[] DailyTemperatures(int[] temperatures)
    {
        var result = new int[temperatures.Length];
        var stack = new Stack<int>();
        for (int i = 0; i < temperatures.Length; i++)
        {
            while (stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i])
            {
                int previous = stack.Pop(); result[previous] = i - previous;
            }
            stack.Push(i);
        }
        return result;
    }
}
