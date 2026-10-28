using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
string Shape(TreeNode? n) => n == null ? "#" : $"{n.val}({Shape(n.left)},{Shape(n.right)})";
Test("example", () => Equal(Shape(TreeNode.From(3, 9, 20, null, null, 15, 7)), Shape(s.BuildTree([3, 9, 20, 15, 7], [9, 3, 15, 20, 7]))));
Test("left chain", () => Equal("3(2(1(#,#),#),#)", Shape(s.BuildTree([3, 2, 1], [1, 2, 3]))));
Test("single", () => Equal("-1(#,#)", Shape(s.BuildTree([-1], [-1]))));
Test("maximum-depth reconstruction", () =>
{
    var values = Enumerable.Range(0, 3000).ToArray(); TreeNode? root = s.BuildTree(values, values);
    for (int i = 0; i < values.Length; i++) { Check(root != null); Equal(i, root!.val); Check(root.left == null); root = root.right; }
    Check(root == null);
});
return Finish();
