using System.Text;

public class ReferenceSolution : Solution
{
    // O(output) time. Recursive descent: each '[' parses a nested string up to its ']'.
    public override string DecodeString(string s)
    {
        // i is shared by every Parse call, so a nested call continues where the last one stopped.
        int i = 0;

        string Parse()
        {
            var text = new StringBuilder();
            // Read until the ']' that closes this level, or the end of the string.
            while (i < s.Length && s[i] != ']')
            {
                // A plain letter is copied as is.
                if (!char.IsDigit(s[i]))
                {
                    text.Append(s[i]);
                    i += 1;
                    continue;
                }
                // Read a repeat count, which may have several digits.
                int count = 0;
                while (i < s.Length && char.IsDigit(s[i]))
                {
                    count = count * 10 + s[i] - '0';
                    i += 1;
                }
                // Skip '[', parse the inside, then skip ']'.
                i += 1;
                string inner = Parse();
                i += 1;
                // Repeat the decoded inside count times.
                for (int k = 0; k < count; k += 1)
                {
                    text.Append(inner);
                }
            }
            return text.ToString();
        }

        return Parse();
    }
}
