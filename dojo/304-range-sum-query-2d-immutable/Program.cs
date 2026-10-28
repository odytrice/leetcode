using static TestSupport;
NumMatrix Make(int[][] m) => args.Contains("--reference") ? new ReferenceSolution(m) : new NumMatrix(m);
Test("whole rectangle", () => Equal(10, Make([[1, 2], [3, 4]]).SumRegion(0, 0, 1, 1)));
Test("interior", () => Equal(8, Make([[1, 2, 3], [4, 5, 6], [7, 8, 9]]).SumRegion(2, 1, 2, 1)));
Test("negatives", () => { var s = Make([[-1, 2], [3, -4]]); Equal(-1, s.SumRegion(1, 0, 1, 1)); Equal(0, s.SumRegion(0, 0, 1, 1)); });
return Finish();
