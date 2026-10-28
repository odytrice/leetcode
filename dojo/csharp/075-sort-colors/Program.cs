using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
void Verify(int[] input, int[] expected) { s.SortColors(input); Sequence(expected, input); }
Test("example", () => Verify([2, 0, 2, 1, 1, 0], [0, 0, 1, 1, 2, 2]));
Test("reverse", () => Verify([2, 1, 0], [0, 1, 2]));
Test("single", () => Verify([2], [2]));
return Finish();
