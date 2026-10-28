using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
void Verify(int[] input, int[] expected)
{
    var h = ListNode.From(input)!; var nodes = new HashSet<ListNode>();
    for (var p = h; p != null; p = p.next) nodes.Add(p);
    s.ReorderList(h); Sequence(expected, ListNode.Values(h));
    for (var p = h; p != null; p = p.next) Check(nodes.Remove(p), "Nodes must be reused");
    Equal(0, nodes.Count);
}
Test("odd", () => Verify([1, 2, 3, 4, 5], [1, 5, 2, 4, 3]));
Test("even", () => Verify([1, 2, 3, 4], [1, 4, 2, 3]));
Test("single", () => Verify([1], [1]));
return Finish();
