public class ReferenceSolution
{
    // O(n) time and space. Each index is pushed and popped at most once.
    public int[] DailyTemperatures(int[] temperatures)
    {
        var result = new int[temperatures.Length];
        // Indices still waiting for a warmer day, coldest on top.
        var stack = new Stack<int>();
        for (int i = 0; i < temperatures.Length; i += 1)
        {
            // Today is the warmer day for every colder index on the stack.
            while (stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i])
            {
                int previous = stack.Pop();
                result[previous] = i - previous;
            }
            // Today now waits for its own warmer day.
            stack.Push(i);
        }
        // Indices still on the stack never found a warmer day and keep 0.
        return result;
    }
}
