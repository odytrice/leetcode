using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(3, s.DiameterOfBinaryTree(TreeNode.From(1, 2, 3, 4, 5))));
Test("single", () => Equal(0, s.DiameterOfBinaryTree(new TreeNode(1))));
Test("below root", () => Equal(4, s.DiameterOfBinaryTree(TreeNode.From(1, 2, null, 3, 4, 5, null, null, 6))));
Test("maximum-depth tree", () => { var root = new TreeNode(0); var tail = root; for (int i = 1; i < 10_000; i++) { tail.right = new(i); tail = tail.right; } Equal(9_999, s.DiameterOfBinaryTree(root)); });
return Finish();
