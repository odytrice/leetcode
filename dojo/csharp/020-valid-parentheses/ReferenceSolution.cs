public class ReferenceSolution : Solution
{
    // O(n) time. Every closer must match the most recent opener.
    public override bool IsValid(string s)
    {
        var stack = new Stack<char>();
        foreach (char c in s)
        {
            if (c is '(' or '[' or '{')
            {
                stack.Push(c);
                continue;
            }
            char expected = c == ')' ? '(' : c == ']' ? '[' : '{';
            if (!stack.TryPop(out char open) || open != expected)
            {
                return false;
            }
        }
        return stack.Count == 0;
    }
}
