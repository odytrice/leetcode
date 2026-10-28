using static TestSupport;
MinStack Make() => args.Contains("--reference") ? new ReferenceSolution() : new MinStack();
Test("example", () => { var s = Make(); s.Push(-2); s.Push(0); s.Push(-3); Equal(-3, s.GetMin()); s.Pop(); Equal(0, s.Top()); Equal(-2, s.GetMin()); });
Test("duplicate minimum", () => { var s = Make(); s.Push(1); s.Push(1); s.Pop(); Equal(1, s.GetMin()); });
Test("int limits", () => { var s = Make(); s.Push(int.MinValue); s.Push(int.MaxValue); Equal(int.MinValue, s.GetMin()); Equal(int.MaxValue, s.Top()); });
return Finish();
