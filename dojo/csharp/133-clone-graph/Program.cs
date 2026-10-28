using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("cycle and shared neighbors", () =>
{
    var originals = Enumerable.Range(1, 3).Select(v => new Node(v)).ToArray();
    for (int i = 0; i < 3; i++) originals[i].neighbors = originals.Where(n => n != originals[i]).ToList();
    var copy = s.CloneGraph(originals[0])!; var seen = new Dictionary<int, Node>(); var q = new Queue<Node>(); q.Enqueue(copy);
    while (q.TryDequeue(out var n))
    {
        if (seen.TryGetValue(n.val, out var prior)) { Check(ReferenceEquals(prior, n)); continue; }
        Check(!originals.Contains(n)); seen[n.val] = n; Set(originals[n.val - 1].neighbors.Select(x => x.val), n.neighbors.Select(x => x.val));
        foreach (var neighbor in n.neighbors) q.Enqueue(neighbor);
    }
    Equal(3, seen.Count);
});
Test("isolated", () => { var n = new Node(1); var c = s.CloneGraph(n)!; Check(!ReferenceEquals(n, c)); Equal(1, c.val); Equal(0, c.neighbors.Count); });
Test("empty", () => Check(s.CloneGraph(null) == null));
return Finish();
