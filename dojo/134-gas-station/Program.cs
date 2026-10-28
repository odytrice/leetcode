using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(3, s.CanCompleteCircuit([1, 2, 3, 4, 5], [3, 4, 5, 1, 2])));
Test("impossible", () => Equal(-1, s.CanCompleteCircuit([2, 3, 4], [3, 4, 3])));
Test("single", () => Equal(0, s.CanCompleteCircuit([5], [5])));
return Finish();
