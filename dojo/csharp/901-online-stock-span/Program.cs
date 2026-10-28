using static TestSupport;
StockSpanner Make() => args.Contains("--reference") ? new ReferenceSolution() : new StockSpanner();
Test("example", () => { var s = Make(); Sequence(new[] { 1, 1, 1, 2, 1, 4, 6 }, new[] { 100, 80, 60, 70, 60, 75, 85 }.Select(s.Next)); });
Test("equal prices", () => { var s = Make(); Equal(1, s.Next(5)); Equal(2, s.Next(5)); Equal(3, s.Next(5)); });
Test("independent instances", () => { var a = Make(); a.Next(1); Equal(1, Make().Next(2)); });
return Finish();
