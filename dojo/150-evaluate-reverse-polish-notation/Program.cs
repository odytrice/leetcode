using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(9, s.EvalRPN(["2", "1", "+", "3", "*"])));
Test("operand order", () => Equal(-1, s.EvalRPN(["2", "3", "-"])));
Test("negative division", () => Equal(-2, s.EvalRPN(["-7", "3", "/"])));
return Finish();
