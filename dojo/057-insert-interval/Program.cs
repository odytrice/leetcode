using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
void Verify(int[][] expected, int[][] input, int[] added) => Sequence(expected.Select(x => string.Join(',', x)), s.Insert(input, added).Select(x => string.Join(',', x)));
Test("example", () => Verify([[1, 5], [6, 9]], [[1, 3], [6, 9]], [2, 5]));
Test("bridge", () => Verify([[1, 2], [3, 10], [12, 16]], [[1, 2], [3, 5], [6, 7], [8, 10], [12, 16]], [4, 8]));
Test("empty", () => Verify([[5, 7]], [], [5, 7]));
return Finish();
