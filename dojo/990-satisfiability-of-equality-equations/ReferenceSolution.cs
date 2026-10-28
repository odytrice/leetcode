public class ReferenceSolution : Solution
{
    public override bool EquationsPossible(string[] equations)
    {
        var parent = Enumerable.Range(0, 26).ToArray();
        int Find(int x) { while (parent[x] != x) { parent[x] = parent[parent[x]]; x = parent[x]; } return x; }
        foreach (string e in equations) if (e[1] == '=') parent[Find(e[0] - 'a')] = Find(e[3] - 'a');
        foreach (string e in equations) if (e[1] == '!' && Find(e[0] - 'a') == Find(e[3] - 'a')) return false;
        return true;
    }
}
