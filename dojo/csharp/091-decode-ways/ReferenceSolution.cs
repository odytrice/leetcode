public class ReferenceSolution : Solution
{
    // O(n) time, O(1) space. Each position is reached as one digit or as a valid pair.
    public override int NumDecodings(string s)
    {
        // previous counts decodings of the prefix one digit shorter; current counts the prefix so far.
        int previous = 1;
        int current = s[0] == '0' ? 0 : 1;
        for (int i = 1; i < s.Length; i += 1)
        {
            // A lone '0' is not a letter, so it cannot be decoded as a single digit.
            int next = s[i] == '0' ? 0 : current;
            // A pair from 10 to 26 is also one letter, extending the prefix from two digits back.
            int pair = (s[i - 1] - '0') * 10 + s[i] - '0';
            if (pair is >= 10 and <= 26)
            {
                next += previous;
            }
            // Slide both counts forward one position.
            previous = current;
            current = next;
        }
        return current;
    }
}
