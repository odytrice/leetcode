using System.Text;

public class ReferenceSolution : Solution
{
    // O(output) time. Recursive descent: each '[' parses a nested string up to its ']'.
    public override string DecodeString(string s)
    {
        int i = 0;

        string Parse()
        {
            var text = new StringBuilder();
            while (i < s.Length && s[i] != ']')
            {
                if (!char.IsDigit(s[i]))
                {
                    text.Append(s[i]);
                    i += 1;
                    continue;
                }
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
