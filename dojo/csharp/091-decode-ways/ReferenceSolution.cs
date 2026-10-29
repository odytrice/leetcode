public class ReferenceSolution : Solution
{
    // O(n) time, O(1) space. Each position is reached as one digit or as a valid pair.
    public override int NumDecodings(string s)
    {
        int previous = 1;
        int current = s[0] == '0' ? 0 : 1;
        for (int i = 1; i < s.Length; i += 1)
        {
            int next = s[i] == '0' ? 0 : current;
            int pair = (s[i - 1] - '0') * 10 + s[i] - '0';
            if (pair is >= 10 and <= 26)
            {
                next += previous;
            }
            previous = current;
            current = next;
        }
        return current;
    }
}
