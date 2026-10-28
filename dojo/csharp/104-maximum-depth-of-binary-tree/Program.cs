using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(3, s.MaxDepth(TreeNode.From(3, 9, 20, null, null, 15, 7))));
Test("empty", () => Equal(0, s.MaxDepth(null)));
Test("skewed", () => Equal(3, s.MaxDepth(TreeNode.From(1, null, 2, null, 3))));
return Finish();
