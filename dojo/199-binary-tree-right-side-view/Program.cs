using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Sequence(new[] { 1, 3, 4 }, s.RightSideView(TreeNode.From(1, 2, 3, null, 5, null, 4))));
Test("left continues", () => Sequence(new[] { 1, 3, 4 }, s.RightSideView(TreeNode.From(1, 2, 3, 4))));
Test("empty", () => Equal(0, s.RightSideView(null).Count));
return Finish();
