using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("reachable", () => Equal(true, s.CanJump([2, 3, 1, 1, 4])));
Test("blocked", () => Equal(false, s.CanJump([3, 2, 1, 0, 4])));
Test("already there", () => Equal(true, s.CanJump([0])));
Test("jump over zero", () => Equal(true, s.CanJump([2, 0, 0])));
return Finish();
