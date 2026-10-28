public class ReferenceSolution : Solution
{
    public override int FindCircleNum(int[][] isConnected)
    {
        int n = isConnected.Length, count = n; var parent = Enumerable.Range(0, n).ToArray();
        int Find(int x) { while (parent[x] != x) { parent[x] = parent[parent[x]]; x = parent[x]; } return x; }
        for (int i = 0; i < n; i++) for (int j = i + 1; j < n; j++) if (isConnected[i][j] == 1)
        { int a = Find(i), b = Find(j); if (a != b) { parent[a] = b; count--; } }
        return count;
    }
}
