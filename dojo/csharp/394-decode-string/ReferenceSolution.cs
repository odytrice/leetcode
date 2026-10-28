using System.Text;
public class ReferenceSolution : Solution
{
    public override string DecodeString(string s)
    {
        int i = 0;
        string Parse()
        {
            var text = new StringBuilder();
            while (i < s.Length && s[i] != ']')
            {
                if (!char.IsDigit(s[i])) { text.Append(s[i++]); continue; }
                int count = 0;
                while (i < s.Length && char.IsDigit(s[i])) count = count * 10 + s[i++] - '0';
                i++; string inner = Parse(); i++;
                for (int k = 0; k < count; k++) text.Append(inner);
            }
            return text.ToString();
        }
        return Parse();
    }
}
