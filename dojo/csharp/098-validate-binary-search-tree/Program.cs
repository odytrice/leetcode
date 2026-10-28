using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("valid", () => Equal(true, s.IsValidBST(TreeNode.From(2, 1, 3))));
Test("ancestor violation", () => Equal(false, s.IsValidBST(TreeNode.From(5, 1, 7, null, null, 4, 8))));
Test("duplicate", () => Equal(false, s.IsValidBST(TreeNode.From(2, 2, 3))));
Test("integer limits", () => Equal(true, s.IsValidBST(TreeNode.From(0, int.MinValue, int.MaxValue))));
return Finish();
