using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
void Verify(int[][] expected, TreeNode? root) => Sequence(expected.Select(x => string.Join(',', x)), s.LevelOrder(root).Select(x => string.Join(',', x)));
Test("example", () => Verify([[3], [9, 20], [15, 7]], TreeNode.From(3, 9, 20, null, null, 15, 7)));
Test("empty", () => Verify([], null));
Test("single", () => Verify([[1]], new TreeNode(1)));
return Finish();
