using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("different subtrees", () => { var r = TreeNode.From(3, 5, 1)!; Check(ReferenceEquals(r, s.LowestCommonAncestor(r, r.left!, r.right!))); });
Test("ancestor is target", () => { var r = TreeNode.From(3, 5, 1, 6, 2)!; Check(ReferenceEquals(r.left, s.LowestCommonAncestor(r, r.left!, r.left!.right!))); });
Test("two nodes", () => { var r = TreeNode.From(1, 2)!; Check(ReferenceEquals(r, s.LowestCommonAncestor(r, r, r.left!))); });
Test("maximum-depth tree", () =>
{
    var root = new TreeNode(0); var tail = root;
    for (int i = 1; i < 100_000; i++) { tail.right = new(i); tail = tail.right; }
    Check(ReferenceEquals(root, s.LowestCommonAncestor(root, root, tail)));
});
return Finish();
