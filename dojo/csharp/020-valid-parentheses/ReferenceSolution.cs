public class ReferenceSolution : Solution
{
    // O(n) time. Every closer must match the most recent opener.
    public override bool IsValid(string s)
    {
        // The stack holds openers that are still waiting for their closer.
        var stack = new Stack<char>();
        foreach (char c in s)
        {
            if (c is '(' or '[' or '{')
            {
                stack.Push(c);
                continue;
            }
            // c is a closer here; work out which opener it needs.
            char expected = c == ')' ? '(' : c == ']' ? '[' : '{';
            if (!stack.TryPop(out char open) || open != expected)
            {
                return false;
            }
        }
        // Leftover openers were never closed.
        return stack.Count == 0;
    }
}
