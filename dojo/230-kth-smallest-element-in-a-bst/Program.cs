using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("minimum", () => Equal(1, s.KthSmallest(TreeNode.From(3, 1, 4, null, 2)!, 1)));
Test("interior", () => Equal(3, s.KthSmallest(TreeNode.From(5, 3, 6, 2, 4, null, null, 1)!, 3)));
Test("maximum", () => Equal(4, s.KthSmallest(TreeNode.From(3, 1, 4, null, 2)!, 4)));
return Finish();
