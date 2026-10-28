using static TestSupport;
NumArray Make(int[] a) => args.Contains("--reference") ? new ReferenceSolution(a) : new NumArray(a);
Test("queries", () => { var s = Make([-2, 0, 3, -5, 2, -1]); Equal(1, s.SumRange(0, 2)); Equal(-1, s.SumRange(2, 5)); Equal(-3, s.SumRange(0, 5)); });
Test("single", () => Equal(-5, Make([-5]).SumRange(0, 0)));
Test("repeated query", () => { var s = Make([1, 2]); Equal(3, s.SumRange(0, 1)); Equal(3, s.SumRange(0, 1)); });
return Finish();
