public class ReferenceSolution : Solution
{
    public override bool IsValid(string s)
    {
        var stack = new Stack<char>();
        foreach (char c in s)
        {
            if (c is '(' or '[' or '{') stack.Push(c);
            else if (!stack.TryPop(out char open) || open != (c == ')' ? '(' : c == ']' ? '[' : '{')) return false;
        }
        return stack.Count == 0;
    }
}
