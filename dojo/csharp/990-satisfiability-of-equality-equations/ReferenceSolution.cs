public class ReferenceSolution : Solution
{
    // O(n) time. Union every "==" pair first, then check that no "!=" pair shares a group.
    public override bool EquationsPossible(string[] equations)
    {
        // One union-find slot for each lowercase letter.
        var parent = Enumerable.Range(0, 26).ToArray();

        // Path halving keeps the trees shallow.
        int Find(int x)
        {
            while (parent[x] != x)
            {
                parent[x] = parent[parent[x]];
                x = parent[x];
            }
            return x;
        }

        // Pass 1: letters joined by == go into the same group.
        foreach (string e in equations)
        {
            // Equations look like a==b or a!=b: e[1] gives the kind, e[0] and e[3] the letters.
            if (e[1] == '=')
            {
                parent[Find(e[0] - 'a')] = Find(e[3] - 'a');
            }
        }
        // Pass 2: a != between letters in the same group is a contradiction.
        foreach (string e in equations)
        {
            if (e[1] == '!' && Find(e[0] - 'a') == Find(e[3] - 'a'))
            {
                return false;
            }
        }
        return true;
    }
}
